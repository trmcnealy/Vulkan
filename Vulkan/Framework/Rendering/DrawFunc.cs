namespace Vulkan.Framework;

/**
     * @brief A functor used to draw the primitives for a post-processing step.
     * @see default_draw_func()
     */
public delegate void DrawFunc(CommandBuffer command_buffer, RenderTarget render_target);