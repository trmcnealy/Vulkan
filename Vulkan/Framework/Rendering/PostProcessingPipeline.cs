using System.Collections.Generic;




namespace Vulkan.Framework
{
//class PostProcessingRenderPass;

/**
* @brief A rendering pipeline specialized for fullscreen post-processing and compute passes.
*/
public class PostProcessingPipeline : System.IDisposable
{
//    friend class PostProcessingPassBase;

    /**
    * @brief Creates a rendering pipeline entirely made of fullscreen post-processing subpasses.
    */
    public PostProcessingPipeline(RenderContext render_context, ShaderSource triangle_vs)
    {
        this._RenderContext = render_context;
        this._TriangleVs = new ShaderSource(std::move(triangle_vs));
    }

//    PostProcessingPipeline(@in PostProcessingPipeline to_copy) = delete;
//    PostProcessingPipeline &operator =(@in PostProcessingPipeline to_copy) = delete;

//    PostProcessingPipeline(PostProcessingPipeline &&to_move) = delete;
//    PostProcessingPipeline &operator =(PostProcessingPipeline &&to_move) = delete;

//    virtual ~PostProcessingPipeline() = default;

    /**
     * @brief Runs all renderpasses in this pipeline, recording commands into the given command buffer.
     * @remarks vkb::PostProcessingRenderpass that do not explicitly have a vkb::RenderTarget set will render
     *          to default_render_target.
     */
    public void Draw(CommandBuffer command_buffer, RenderTarget default_render_target)
    {
        for (_CurrentPassIndex = 0; _CurrentPassIndex < _Passes.Count; _CurrentPassIndex++)
        {
            var pass = *_Passes[_CurrentPassIndex];

            if (!pass.prepared)
            {
                pass.prepare(command_buffer, default_render_target);
                pass.prepared = true;
            }

            if (pass.pre_draw)
            {
                pass.pre_draw();
            }

            pass.draw(command_buffer, default_render_target);

            if (pass.post_draw)
            {
                pass.post_draw();
            }
        }

        _CurrentPassIndex = 0;
    }

    /**
     * @brief Gets all of the passes in the pipeline.
     */
    public Array<std::unique_ptr<PostProcessingPassBase>> GetPasses()
    {
        return _Passes;
    }

    /**
     * @brief Get the pass at a certain index as a `TPass`.
     */
    public TPass GetPass<TPass = PostProcessingRenderPass>(nint index)
    {
        return _Passes[index].get() as TPass;
    }

    /**
     * @brief Adds a pass of the given type to the end of the pipeline by constructing it in-place.
     */
    public TPass AddPass<TPass = PostProcessingRenderPass, ConstructorArgs>(ConstructorArgs && ... args)
    {
        _Passes.emplace_back(std::make_unique<TPass>(this, std::forward<ConstructorArgs>(args)...));
        var added_pass = *_Passes[_Passes.Count - 1].get() as TPass;
        return added_pass;
    }

    /**
     * @brief Returns the current render context.
     */
    public RenderContext GetRenderContext()
    {
        return _RenderContext;
    }

    /**
     * @brief Returns the index of the currently-being-drawn pass.
     */
    public nint GetCurrentPassIndex()
    {
        return _CurrentPassIndex;
    }

    private RenderContext _RenderContext = new RenderContext(null);
    private ShaderSource _TriangleVs = new ShaderSource();
    private Array<std::unique_ptr<PostProcessingPassBase>> _Passes = new Array<std::unique_ptr<PostProcessingPassBase>>();
    private nint _CurrentPassIndex = new nint();
}

} // namespace vkb



