using System;

namespace Vulkan.Framework.SubPasses
{
    /**
 * @brief This subpass is responsible for rendering a Scene
 */
    public class GeometrySubpass : Subpass
    {
        /**
     * @brief Constructs a subpass for the geometry pass of Deferred rendering
     * @param render_context Render context
     * @param vertex_shader Vertex shader source
     * @param fragment_shader Fragment shader source
     * @param scene Scene to render on this subpass
     * @param camera Camera used to look at the scene
     */
        public GeometrySubpass(RenderContext render_context,
                               ShaderSource && vertex_source, ShaderSource && fragment_source, Sg.Scene scene_,
                                                                                                        Sg.Camera camera) : base({
            render_context, std::move(vertex_source), std::move(fragment_source)
        })
        {
            this.meshes = scene_.get_components<Sg.Mesh>();
            this.camera = camera;
            this.scene  = scene_;
        }

//    virtual ~GeometrySubpass() = default;

        public override void prepare()
        {
            // Build all shader variance upfront
            var device = render_context.get_device();
            foreach(var mesh in meshes)
            {
                foreach(var sub_mesh in mesh.get_submeshes())
                {
                    var variant     = sub_mesh.get_shader_variant();
                    var vert_module = device.get_resource_cache().request_shader_module(VK_SHADER_STAGE_VERTEX_BIT,   get_vertex_shader(),   variant);
                    var frag_module = device.get_resource_cache().request_shader_module(VK_SHADER_STAGE_FRAGMENT_BIT, get_fragment_shader(), variant);
                }
            }
        }

        /**
     * @brief Record draw commands
     */
        public override void draw(CommandBuffer command_buffer)
        {
            std::multimap<float, Tuple<Sg.Node, Sg.SubMesh>> opaque_nodes      = new std::multimap<float, Tuple<Sg.Node, Sg.SubMesh>>();
            std::multimap<float, Tuple<Sg.Node, Sg.SubMesh>> transparent_nodes = new std::multimap<float, Tuple<Sg.Node, Sg.SubMesh>>();

            get_sorted_nodes(opaque_nodes, transparent_nodes);

            // Draw opaque objects in front-to-back order
            for(var node_it = opaque_nodes.begin(); node_it != opaque_nodes.end(); node_it++)
            {
                update_uniform(command_buffer, *node_it.second.first, thread_index);

                    // Invert the front face if the mesh was flipped
                    in auto scale      = node_it.second.first.get_transform().get_scale();
                bool        flipped    = scale.x * scale.y * scale.z < 0;
                VkFrontFace front_face = flipped ? VK_FRONT_FACE_CLOCKWISE : VK_FRONT_FACE_COUNTER_CLOCKWISE;

                draw_submesh(command_buffer, *node_it.second.second, front_face);
            }

            // Enable alpha blending
            ColorBlendAttachmentState color_blend_attachment = new ColorBlendAttachmentState();
            color_blend_attachment.blend_enable           = true;
            color_blend_attachment.src_color_blend_factor = VK_BLEND_FACTOR_SRC_ALPHA;
            color_blend_attachment.dst_color_blend_factor = VK_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA;
            color_blend_attachment.src_alpha_blend_factor = VK_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA;

            ColorBlendState color_blend_state = new ColorBlendState();
            color_blend_state.attachments.resize(get_output_attachments().size());
            foreach(var it in color_blend_state.attachments)
            {
                it = color_blend_attachment;
            }

            command_buffer.set_color_blend_state(color_blend_state);

            command_buffer.set_depth_stencil_state(get_depth_stencil_state());

            // Draw transparent objects in back-to-front order
            for(var node_it = transparent_nodes.rbegin(); node_it != transparent_nodes.rend(); node_it++)
            {
                update_uniform(command_buffer, *node_it.second.first, thread_index);

                draw_submesh(command_buffer, *node_it.second.second);
            }
        }

        /**
     * @brief Thread index to use for allocating resources
     */
        public void set_thread_index(uint index)
        {
            thread_index = index;
        }

        protected virtual void update_uniform(CommandBuffer command_buffer,
                                              Sg.Node       node,
                                              nint          thread_index = 0)
        {
            GlobalUniform global_uniform = new GlobalUniform();

            global_uniform.camera_view_proj = camera.get_pre_rotation() * vulkan_style_projection(camera.get_projection()) * camera.get_view();

            var render_frame = get_render_context().get_active_frame();

            var transform = node.get_transform();

            var allocation = render_frame.allocate_buffer(VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT, sizeof(GlobalUniform), thread_index);

            global_uniform.model = transform.get_world_matrix();

            global_uniform.camera_position = Vector3F(glm.inverse[]camera.get_view());

            allocation.update(global_uniform);

            command_buffer.bind_buffer(allocation.get_buffer(), allocation.get_offset(), allocation.get_size(), 0, 1, 0);
        }

        protected void draw_submesh(CommandBuffer command_buffer,
                                    Sg.SubMesh    sub_mesh,
                                    VkFrontFace   front_face = VK_FRONT_FACE_COUNTER_CLOCKWISE)
        {
            var device = command_buffer.get_device();

            prepare_pipeline_state(command_buffer, front_face, sub_mesh.get_material().double_sided);

            MultisampleState multisample_state = new MultisampleState();
            multisample_state.rasterization_samples = sample_count;
            command_buffer.set_multisample_state(multisample_state);

            var vert_shader_module = device.get_resource_cache().request_shader_module(VK_SHADER_STAGE_VERTEX_BIT,   get_vertex_shader(),   sub_mesh.get_shader_variant());
            var frag_shader_module = device.get_resource_cache().request_shader_module(VK_SHADER_STAGE_FRAGMENT_BIT, get_fragment_shader(), sub_mesh.get_shader_variant());

            Array<ShaderModule> shader_modules = new Array<ShaderModule>()
            {
                &vert_shader_module,
                &frag_shader_module
            };

            var pipeline_layout = prepare_pipeline_layout(command_buffer, shader_modules);

            command_buffer.bind_pipeline_layout(pipeline_layout);

            if(pipeline_layout.get_push_constant_range_stage(sizeof(PBRMaterialUniform)) != 0)
            {
                prepare_push_constants(command_buffer, sub_mesh);
            }

            DescriptorSetLayout descriptor_set_layout = pipeline_layout.get_descriptor_set_layout(0);

            foreach(var texture in sub_mesh.get_material().textures)
            {
                if(auto layout_binding = descriptor_set_layout.get_layout_binding(texture.first))
                {
                    command_buffer.bind_image(texture.second.get_image().get_vk_image_view(), texture.second.get_sampler().vk_sampler, 0, layout_binding.binding, 0);
                }
            }

            var vertex_input_resources = pipeline_layout.get_resources(ShaderResourceType.Input, VK_SHADER_STAGE_VERTEX_BIT);

            VertexInputState vertex_input_state = new VertexInputState();

            foreach(var input_resource in vertex_input_resources)
            {
                Sg.VertexAttribute attribute = new Sg.VertexAttribute();

                if(!sub_mesh.get_attribute(input_resource.name, attribute))
                {
                    continue;
                }

                VkVertexInputAttributeDescription vertex_attribute = new VkVertexInputAttributeDescription();
                vertex_attribute.binding  = input_resource.location;
                vertex_attribute.format   = attribute.format;
                vertex_attribute.location = input_resource.location;
                vertex_attribute.offset   = attribute.offset;

                vertex_input_state.attributes.push_back(vertex_attribute);

                VkVertexInputBindingDescription vertex_binding = new VkVertexInputBindingDescription();
                vertex_binding.binding = input_resource.location;
                vertex_binding.stride  = attribute.stride;

                vertex_input_state.bindings.push_back(vertex_binding);
            }

            command_buffer.set_vertex_input_state(vertex_input_state);

            // Find submesh vertex buffers matching the shader input attribute names
            foreach(var input_resource in vertex_input_resources)
            {
                in auto buffer_iter = sub_mesh.vertex_buffers.find(input_resource.name);

                if(buffer_iter != sub_mesh.vertex_buffers.end())
                {
                    Array<std::reference_wrapper<Buffer>> buffers = new Array<std::reference_wrapper<Buffer>>();
                    buffers.emplace_back(std::@ref(buffer_iter.second));

                    // Bind vertex buffers only for the attribute locations defined
                    command_buffer.bind_vertex_buffers(input_resource.location, std::move(buffers),  {
                        0
                    });
                }
            }

            draw_submesh_command(command_buffer, sub_mesh);
        }

        protected virtual void prepare_pipeline_state(CommandBuffer command_buffer,
                                                      VkFrontFace   front_face,
                                                      bool          double_sided_material)
        {
            RasterizationState rasterization_state = base_rasterization_state;
            rasterization_state.front_face = front_face;

            if(double_sided_material)
            {
                rasterization_state.cull_mode = VK_CULL_MODE_NONE;
            }

            command_buffer.set_rasterization_state(rasterization_state);

            MultisampleState multisample_state = new MultisampleState();
            multisample_state.rasterization_samples = sample_count;
            command_buffer.set_multisample_state(multisample_state);
        }

        protected virtual PipelineLayout prepare_pipeline_layout(CommandBuffer       command_buffer,
                                                                 Array<ShaderModule> shader_modules)
        {
            // Sets any specified resource modes
            foreach(var shader_module in shader_modules)
            {
                foreach(var resource_mode in resource_mode_map)
                {
                    shader_module.set_resource_mode(resource_mode.first, resource_mode.second);
                }
            }

            return command_buffer.get_device().get_resource_cache().request_pipeline_layout(shader_modules);
        }

        protected virtual void prepare_push_constants(CommandBuffer command_buffer,
                                                      Sg.SubMesh    sub_mesh)
        {
            var pbr_material = sub_mesh.get_material() as Sg.PBRMaterial;

            PBRMaterialUniform pbr_material_uniform = new PBRMaterialUniform();
            pbr_material_uniform.base_color_factor = pbr_material.base_color_factor;
            pbr_material_uniform.metallic_factor   = pbr_material.metallic_factor;
            pbr_material_uniform.roughness_factor  = pbr_material.roughness_factor;

            var data = GlobalMembers.ToBytes(pbr_material_uniform);

            if(!data.empty())
            {
                command_buffer.push_constants(data);
            }
        }

        protected virtual void draw_submesh_command(CommandBuffer command_buffer,
                                                    Sg.SubMesh    sub_mesh)
        {
            // Draw submesh indexed if indices exists
            if(sub_mesh.vertex_indices != 0)
            {
                // Bind index buffer of submesh
                command_buffer.bind_index_buffer(*sub_mesh.index_buffer, sub_mesh.index_offset, sub_mesh.index_type);

                // Draw submesh using indexed data
                command_buffer.draw_indexed(sub_mesh.vertex_indices, 1, 0, 0, 0);
            }
            else
            {
                // Draw submesh using vertices only
                command_buffer.draw(sub_mesh.vertices_count, 1, 0, 0);
            }
        }

        /**
     * @brief Sorts objects based on distance from camera and classifies them
     *        into opaque and transparent in the arrays provided
     */
        protected void get_sorted_nodes(std::multimap<float, Tuple<Sg.Node, Sg.SubMesh>> opaque_nodes,
                                        std::multimap<float, Tuple<Sg.Node, Sg.SubMesh>> transparent_nodes)
        {
            var camera_transform = camera.get_node().get_transform().get_world_matrix();

            foreach(var mesh in meshes)
            {
                foreach(var node in mesh.get_nodes())
                {
                    var node_transform = node.get_transform().get_world_matrix();

                    Sg.AABB mesh_bounds = mesh.get_bounds();

                    Sg.AABB world_bounds = new sg.AABB(mesh_bounds.get_min(), mesh_bounds.get_max());
                    world_bounds.transform(node_transform);

                    float distance = glm.length(Vector3F(camera_transform[3]) - world_bounds.get_center());

                    foreach(var sub_mesh in mesh.get_submeshes())
                    {
                        if(sub_mesh.get_material().alpha_mode == Sg.AlphaMode.Blend)
                        {
                            transparent_nodes.emplace(distance, Tuple.Create(node, sub_mesh));
                        }
                        else
                        {
                            opaque_nodes.emplace(distance, Tuple.Create(node, sub_mesh));
                        }
                    }
                }
            }
        }

        protected Sg.Camera camera;

        protected Array<Sg.Mesh> meshes = new Array<Sg.Mesh>();

        protected Sg.Scene scene;

        protected uint thread_index =
        {
            0
        };

        protected RasterizationState base_rasterization_state =
        {
        };
    }
}
