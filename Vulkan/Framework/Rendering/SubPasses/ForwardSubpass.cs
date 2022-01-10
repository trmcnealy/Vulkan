using System;

namespace Vulkan.Framework.SubPasses
{
    /**
 * @brief This subpass is responsible for rendering a Scene
 */
    public class ForwardSubpass : GeometrySubpass
    {
        /**
     * @brief Constructs a subpass designed for forward rendering
     * @param render_context Render context
     * @param vertex_shader Vertex shader source
     * @param fragment_shader Fragment shader source
     * @param scene Scene to render on this subpass
     * @param camera Camera used to look at the scene
     */
        public ForwardSubpass(RenderContext render_context,
                              ShaderSource && vertex_source, ShaderSource && fragment_source, Sg.Scene scene_,
                                                                                                       Sg.Camera camera) : base({
            render_context, std::move(vertex_source), std::move(fragment_source), scene_, camera
        })
        {
        }

//    virtual ~ForwardSubpass() = default;

        public override void prepare()
        {
            var device = render_context.get_device();
            foreach(var mesh in meshes)
            {
                foreach(var sub_mesh in mesh.get_submeshes())
                {
                    var variant = sub_mesh.get_mut_shader_variant();

                    // Same as Geometry except adds lighting definitions to sub mesh variants.
                    variant.add_definitions({
                        "MAX_LIGHT_COUNT " + Convert.ToString(DefineConstants.MAX_FORWARD_LIGHT_COUNT)
                    });

                    variant.add_definitions(light_type_definitions);

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
            allocate_lights<ForwardLights>(scene.get_components<Sg.Light>(), DefineConstants.MAX_FORWARD_LIGHT_COUNT);
            command_buffer.bind_lighting(get_lighting_state(), 0, 4);

            GeometrySubpass.draw(command_buffer);
        }
    }
}
