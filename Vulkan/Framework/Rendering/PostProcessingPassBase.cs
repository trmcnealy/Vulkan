



namespace Vulkan.Framework
{
//class PostProcessingPipeline;

/**
* @brief The base of all types of passes in a vkb::PostProcessingPipeline.
*/
public abstract class PostProcessingPassBase : System.IDisposable
{
//    friend class PostProcessingPipeline;

    public PostProcessingPassBase(PostProcessingPipeline parent)
    {
        this.Parent = parent;
    }

//    PostProcessingPassBase(@in PostProcessingPassBase to_copy) = delete;
//    PostProcessingPassBase &operator =(@in PostProcessingPassBase to_copy) = delete;

//    PostProcessingPassBase(PostProcessingPassBase &&to_move) = default;
//    PostProcessingPassBase &operator =(PostProcessingPassBase &&to_move) = default;

//    virtual ~PostProcessingPassBase() = default;

    /**
     * @brief Prepares this pass, recording commands into the given command buffer.
     * @remarks Passes that that do not explicitly have a vkb::RenderTarget set will render
     *          to default_render_target.
     */
    protected virtual void Prepare(CommandBuffer command_buffer, RenderTarget default_render_target)
    {
        Prepared = true;
    }

    /**
     * @brief Runs this pass, recording commands into the given command buffer.
     * @remarks Passes that that do not explicitly have a vkb::RenderTarget set will render
     *          to default_render_target.
     */
    protected virtual void Draw(CommandBuffer command_buffer, RenderTarget default_render_target)
    {
    }

    /**
     * @brief A functor ran in the context of this renderpass.
     * @see set_pre_draw_func(), set_post_draw_func()
     */
    protected delegate void HookFunc();

    // NOTE: Protected members are exposed via getters and setters in PostProcessingPass<>
    protected PostProcessingPipeline Parent = new PostProcessingPipeline(null);
    protected bool Prepared = false;

    protected RenderTarget RenderTarget = new RenderTarget(null);
    protected Sampler DefaultSampler = new Sampler();

    protected HookFunc PreDraw = new HookFunc();
    protected HookFunc PostDraw = new HookFunc();

    /**
     * @brief Returns the parent's render context.
     */
    protected RenderContext GetRenderContext()
    {
        return Parent.render_context;
    }

    /**
    * @brief Returns the parent's fullscreen triangle vertex shader source.
    */
    protected ShaderSource GetTriangleVs()
    {
        return Parent.triangle_vs;
    }

    protected class BarrierInfo
    {
        public VkPipelineStageFlagBits PipelineStage = new VkPipelineStageFlagBits(); // Pipeline stage of this pass' inputs/outputs
        public VkAccessFlagBits ImageReadAccess = new VkAccessFlagBits(); // Access mask for images read from this pass
        public VkAccessFlagBits ImageWriteAccess = new VkAccessFlagBits(); // Access mask for images written to by this pass
    }

    /**
    * @brief Returns information that can be used to setup memory barriers of images
    *        that are produced (e.g. image stores, color attachment output) by this pass.
    */
    protected abstract BarrierInfo GetSrcBarrierInfo();

    /**
    * @brief Returns information that can be used to setup memory barriers of images
    *        that are consumed (e.g. image loads, texture sampling) by this pass.
    */
    protected abstract BarrierInfo GetDstBarrierInfo();

    /**
     * @brief Convenience function that calls get_src_barrier_info() on the previous pass of the pipeline,
     *        if any, or returns the specified default if this is the first pass in the pipeline.
     */
    protected PostProcessingPassBase.BarrierInfo GetPredecessorSrcBarrierInfo(BarrierInfo fallback = new BarrierInfo())
    {
        nint cur_pass_i = Parent.GetCurrentPassIndex();
        if (cur_pass_i > 0)
        {
            in auto prev_pass = Parent.GetPass<PostProcessingPassBase>(cur_pass_i - 1);
            return prev_pass.get_src_barrier_info();
        }
        else
        {
            return fallback;
        }
    }
}

using PostProcessingPassBase.PostProcessingPassBase;

//    PostProcessingPass(@in PostProcessingPass to_copy) = delete;
//    PostProcessingPass &operator =(@in PostProcessingPass to_copy) = delete;

//    PostProcessingPass(PostProcessingPass &&to_move) = default;
//    PostProcessingPass &operator =(PostProcessingPass &&to_move) = default;

//    virtual ~PostProcessingPass() = default;

    /**
     * @brief Sets a functor that, if non-null, will be invoked before draw()ing this pass.
     * @remarks The function is invoked after ending the previous RenderPass, and before beginning this one.
     */
    public Self SetPreDrawFunc(HookFunc && new_func)
    {
        PreDraw = std::move(new_func);

        return (Self) this;
    }

    /**
     * @brief Sets a functor that, if non-null, will be invoked after draw()ing this pass.
     * @remarks The function after drawing the last subpass, and before ending this RenderPass.
     */
    public Self SetPostDrawFunc(HookFunc && new_func)
    {
        PostDraw = std::move(new_func);

        return (Self) this;
    }

    /**
    * @brief Render target to output to.
    *        If set, this pass will output to the given render target instead of the one passed to draw().
    */
    public RenderTarget GetRenderTarget()
    {
        return RenderTarget;
    }

    /**
    * @copydoc get_render_target()
    */
    public Self SetRenderTarget(RenderTarget new_render_target)
    {
        RenderTarget = new_render_target;

        return (Self) this;
    }

    /**
    * @brief Returns the vkb::PostProcessingPipeline that is the parent of this pass.
    */
    public PostProcessingPipeline GetParent()
    {
        return Parent;
    }
}

} // namespace vkb



