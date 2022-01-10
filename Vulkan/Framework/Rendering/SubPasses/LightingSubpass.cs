using System;

namespace Vulkan.Framework.SubPasses
{
    /**
 * @brief Lighting pass of Deferred Rendering
 */
    public class LightingSubpass : Subpass
    {
        public LightingSubpass(RenderContext render_context,
                               ShaderSource && vertex_shader, ShaderSource && fragment_shader, Sg.Camera cam,
                                                                                                         Sg.Scene scene_) : base({
            render_context, std::move(vertex_shader), std::move(fragment_shader)
        })
        {
            this.camera = cam;
            this.scene  = scene_;
        }

        public override void prepare()
        {
            lighting_variant.add_definitions({
                "MAX_LIGHT_COUNT " + Convert.ToString(DefineConstants.MAX_DEFERRED_LIGHT_COUNT)
            });

            lighting_variant.add_definitions(light_type_definitions);
            // Build all shaders upfront
            var resource_cache = render_context.get_device().get_resource_cache();
            resource_cache.request_shader_module(VK_SHADER_STAGE_VERTEX_BIT,   get_vertex_shader(),   lighting_variant);
            resource_cache.request_shader_module(VK_SHADER_STAGE_FRAGMENT_BIT, get_fragment_shader(), lighting_variant);
        }

        public override void draw(CommandBuffer command_buffer)
        {
            allocate_lights<DeferredLights>(scene.get_components<Sg.Light>(), DefineConstants.MAX_DEFERRED_LIGHT_COUNT);
            command_buffer.bind_lighting(get_lighting_state(), 0, 4);

            // Get shaders from cache
            var resource_cache     = command_buffer.get_device().get_resource_cache();
            var vert_shader_module = resource_cache.request_shader_module(VK_SHADER_STAGE_VERTEX_BIT,   get_vertex_shader(),   lighting_variant);
            var frag_shader_module = resource_cache.request_shader_module(VK_SHADER_STAGE_FRAGMENT_BIT, get_fragment_shader(), lighting_variant);

            Array<ShaderModule> shader_modules = new Array<ShaderModule>()
            {
                &vert_shader_module,
                &frag_shader_module
            };

            // Create pipeline layout and bind it
            var pipeline_layout = resource_cache.request_pipeline_layout(shader_modules);
            command_buffer.bind_pipeline_layout(pipeline_layout);

            // Get image views of the attachments
            var render_target = get_render_context().get_active_frame().get_render_target();
            var target_views  = render_target.get_views();

            // Bind depth, albedo, and normal as input attachments
            var depth_view = target_views.at(1);
            command_buffer.bind_input(depth_view, 0, 0, 0);

            var albedo_view = target_views.at(2);
            command_buffer.bind_input(albedo_view, 0, 1, 0);

            var normal_view = target_views.at(3);
            command_buffer.bind_input(normal_view, 0, 2, 0);

            // Set cull mode to front as full screen triangle is clock-wise
            RasterizationState rasterization_state = new RasterizationState();
            rasterization_state.cull_mode = VK_CULL_MODE_FRONT_BIT;
            command_buffer.set_rasterization_state(rasterization_state);

            // Populate uniform values
            LightUniform light_uniform = new LightUniform();

            // Inverse resolution
            light_uniform.inv_resolution.x = 1.0f / render_target.get_extent().width;
            light_uniform.inv_resolution.y = 1.0f / render_target.get_extent().height;

            // Inverse view projection
            light_uniform.inv_view_proj = glm.inverse(vulkan_style_projection(camera.get_projection()) * camera.get_view());

            // Allocate a buffer using the buffer pool from the active frame to store uniform values and bind it
            var render_frame = get_render_context().get_active_frame();
            var allocation   = render_frame.allocate_buffer(VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT, sizeof(LightUniform));
            allocation.update(light_uniform);
            command_buffer.bind_buffer(allocation.get_buffer(), allocation.get_offset(), allocation.get_size(), 0, 3, 0);

            // Draw full screen triangle triangle
            command_buffer.draw(3, 1, 0, 0);
        }

        private Sg.Camera camera;

        private Sg.Scene scene;

        private ShaderVariant lighting_variant = new ShaderVariant();
    }
}
