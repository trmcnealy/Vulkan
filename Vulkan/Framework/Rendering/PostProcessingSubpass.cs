namespace Vulkan.Framework;

/**
* @brief A single step of a vkb::PostProcessingRenderPass.
*/
public class PostProcessingSubpass : Subpass
{
    public PostProcessingSubpass(PostProcessingRenderPass parent, RenderContext render_context, ShaderSource && triangle_vs, ShaderSource && fs, ShaderVariant && fs_variant = {}) :