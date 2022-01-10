using System.Collections.Generic;
using System.Diagnostics;







namespace Vulkan.Framework
{
/**
 * @brief A RenderPipeline is a sequence of Subpass objects.
 * Subpass holds shaders and can draw the core::sg::Scene.
 * More subpasses can be added to the sequence if required.
 * For example, postprocessing can be implemented with two pipelines which
 * share render targets.
 *
 * GeometrySubpass -> Processes Scene for Shaders, use by itself if shader requires no lighting
 * ForwardSubpass -> Binds lights at the beginning of a GeometrySubpass to create Forward Rendering, should be used with most default shaders
 * LightingSubpass -> Holds a Global Light uniform, Can be combined with GeometrySubpass to create Deferred Rendering
 */
public class RenderPipeline : System.IDisposable
{
    public RenderPipeline(Array<std::unique_ptr<Subpass>> &&subpasses_ = {})
    {
        this._Subpasses = std::move(subpasses_);
        Prepare();

        // Default clear value
        _ClearValue[0].color = {0.0f, 0.0f, 0.0f, 1.0f};
        _ClearValue[1].depthStencil = {0.0f, ~0U};
    }

//    RenderPipeline(@in RenderPipeline) = delete;

//    RenderPipeline(RenderPipeline &&) = default;

//    virtual ~RenderPipeline() = default;

//    RenderPipeline &operator =(@in RenderPipeline) = delete;

//    RenderPipeline &operator =(RenderPipeline &&) = default;

    /**
     * @brief Prepares the subpasses
     */
    public void Prepare()
    {
        foreach (var subpass in _Subpasses)
        {
            subpass.prepare();
        }
    }

    /**
     * @return Load store info
     */
    public Array<LoadStoreInfo> GetLoadStore()
    {
        return _LoadStore;
    }

    /**
     * @param load_store Load store info to set
     */
    public void SetLoadStore(Array<LoadStoreInfo> ls)
    {
        _LoadStore = ls;
    }

    /**
     * @return Clear values
     */
    public Array<VkClearValue> GetClearValue()
    {
        return _ClearValue;
    }

    /**
     * @param clear_values Clear values to set
     */
    public void SetClearValue(Array<VkClearValue> cv)
    {
        _ClearValue = cv;
    }

    /**
     * @brief Appends a subpass to the pipeline
     * @param subpass Subpass to append
     */
    public void AddSubpass(std::unique_ptr<Subpass> &&subpass)
    {
        subpass.prepare();
        _Subpasses.emplace_back(std::move(subpass));
    }

    public Array<std::unique_ptr<Subpass>> GetSubpasses()
    {
        return _Subpasses;
    }

    /**
     * @brief Record draw commands for each Subpass
     */
    public void Draw(CommandBuffer command_buffer, RenderTarget render_target, VkSubpassContents contents = VK_SUBPASS_CONTENTS_INLINE)
    {
        Debug.Assert(_Subpasses.Count > 0 && "Render pipeline should contain at least one sub-pass");

        // Pad clear values if they're less than render target attachments
        while (_ClearValue.Count < render_target.GetAttachments().Count)
        {
            _ClearValue.Add(new VkClearValue(0.0f, 0.0f, 0.0f, 1.0f));
        }

        for (nint i = 0; i < _Subpasses.Count; ++i)
        {
            _ActiveSubpassIndex = i;

            var subpass = _Subpasses[i];

            subpass.update_render_target_attachments(render_target);

            if (i == 0)
            {
                command_buffer.begin_render_pass(render_target, _LoadStore, _ClearValue, _Subpasses, contents);
            }
            else
            {
                command_buffer.NextSubpass();
            }

            subpass.draw(command_buffer);
        }

        _ActiveSubpassIndex = 0;
    }

    /**
     * @return Subpass currently being recorded, or the first one
     *         if drawing has not started
     */
    public std::unique_ptr<Subpass> GetActiveSubpass()
    {
        return _Subpasses[_ActiveSubpassIndex];
    }

    private Array<std::unique_ptr<Subpass>> _Subpasses = new Array<std::unique_ptr<Subpass>>();

    /// Default to two load store
    private Array<LoadStoreInfo> _LoadStore = new Array<LoadStoreInfo>(2);

    /// Default to two clear values
    private Array<VkClearValue> _ClearValue = new Array<VkClearValue>(2);

    private nint _ActiveSubpassIndex = new nint();
}
} // namespace vkb





