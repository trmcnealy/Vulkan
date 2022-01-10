using System.Collections.Generic;



namespace Vulkan.Framework
{
    /**
 * @brief Maps in-shader binding names to indices into a RenderTarget's attachments.
 */

/**
 * @brief Maps in-shader binding names to the core::SampledImage to bind.
 */

/**
 * @brief Maps in-shader binding names to the core::ImageView to bind for storage images.
 */

/**
 * @brief A Array of indices into a RenderTarget's attachments.
 */

/**
 * @brief A set of indices into a RenderTarget's attachments.
 */

//class PostProcessingRenderPass;

base(render_context, std::move(triangle_vs), std::move(fs))
    {
        this._Parent = parent;
        this._FsVariant = new ShaderVariant(std::move(_FsVariant));
        set_disable_depth_stencil_attachment(true);

        Array<uint> input_attachments = new Array<uint>();
        foreach (in it in this._InputAttachments)
        {
            input_attachments.Add(it.second);
        }
        set_input_attachments(input_attachments);
    }

//    PostProcessingSubpass(@in PostProcessingSubpass to_copy) = delete;
//    PostProcessingSubpass &operator =(@in PostProcessingSubpass to_copy) = delete;

    public PostProcessingSubpass(PostProcessingSubpass && to_move) : base({std::move(to_move)})
    {
        this._Parent = std::move(to_move.parent);
        this._FsVariant = new ShaderVariant(std::move(to_move.fs_variant));
        this._InputAttachments = std::move(to_move.input_attachments);
        this._SampledImages = std::move(to_move.sampled_images);
    }

//    PostProcessingSubpass &operator =(PostProcessingSubpass &&to_move) = delete;

//    ~PostProcessingSubpass() = default;

    /**
    * @brief Maps the names of input attachments in the shader to indices into the render target's images.
    *        These are given as `subpassInput`s to the subpass, at set 0; they are bound automatically according to their name.
    */
    public AttachmentMap GetInputAttachments()
    {
        return _InputAttachments;
    }

    /**
    * @brief Maps the names of samplers in the shader to vkb::core::SampledImage.
    *        These are given as samplers to the subpass, at set 0; they are bound automatically according to their name.
    * @remarks PostProcessingPipeline::get_sampler() is used as the default sampler if none is specified.
    *          The RenderTarget for the current PostProcessingSubpass is used if none is specified for attachment images.
    */
    public SampledMap GetSampledImages()
    {
        return _SampledImages;
    }

    /**
    * @brief Maps the names of storage images in the shader to vkb::core::ImageView.
    *        These are given as image2D[Array] to the subpass, at set 0; they are bound automatically according to their name.
    */
    public StorageImageMap GetStorageImages()
    {
        return _StorageImages;
    }

    /**
    * @brief Returns the shader variant used for this postprocess' fragment shader.
    */
    public ShaderVariant GetFsVariant()
    {
        return _FsVariant;
    }

    /**
    * @brief Sets the shader variant that will be used for this postprocess' fragment shader.
    */
    public PostProcessingSubpass SetFsVariant(ShaderVariant && new_variant)
    {
        _FsVariant = std::move(new_variant);

        return this;
    }

    /**
     * @brief Changes (or adds) the input attachment at name for this step.
     */
    public PostProcessingSubpass BindInputAttachment(utf8string name, uint new_input_attachment)
    {
        _InputAttachments[name] = new_input_attachment;

        Array<uint> input_attachments = new Array<uint>();
        foreach (in it in this._InputAttachments)
        {
            input_attachments.Add(it.second);
        }
        set_input_attachments(input_attachments);

        _Parent.load_stores_dirty = true;
        return this;
    }

    /**
     * @brief Changes (or adds) the sampled image at name for this step.
     * @remarks If no RenderTarget is specifically set for the core::SampledImage,
     *          it will default to sample in the RenderTarget currently bound for drawing in the parent PostProcessingRenderpass.
     */
    public PostProcessingSubpass BindSampledImage(utf8string name, SampledImage && new_image)
    {
        var it = _SampledImages.find(name);
        if (it != _SampledImages.end())
        {
            it.second = std::move(new_image);
        }
        else
        {
            _SampledImages.emplace(name, std::move(new_image));
        }

        _Parent.load_stores_dirty = true;
        return this;
    }

    /**
     * @brief Changes (or adds) the storage image at name for this step.
     */
    public PostProcessingSubpass BindStorageImage(utf8string name, ImageView new_image)
    {
        var it = _StorageImages.find(name);
        if (it != _StorageImages.end())
        {
            it.second = new_image;
        }
        else
        {
            _StorageImages.emplace(name, new_image);
        }

        return this;
    }

    /**
     * @brief Set the constants that are pushed before each fullscreen draw.
     */
    public PostProcessingSubpass SetPushConstants(Array<byte> data)
    {
        _PushConstantsData = data;
        return this;
    }

    /**
     * @brief Set the constants that are pushed before each fullscreen draw.
     */
    public PostProcessingSubpass SetPushConstants<T>(in T data)
    {
        _PushConstantsData.Capacity = sizeof(in);
        var data_ptr = reinterpret_cast<byte>(data);
        _PushConstantsData.assign(data_ptr, data_ptr + sizeof(in));

        return this;
    }

    /**
     * @brief Sets the function used to draw this postprocessing step.
     * @see default_draw_func()
     */
    public PostProcessingSubpass SetDrawFunc(DrawFunc && new_func)
    {
        _DrawFunc = std::move(new_func);
        return this;
    }

    /**
     * @brief The default function used to draw a step; it draws 1 instance with 3 vertices.
     */
    public static void DefaultDrawFunc(CommandBuffer command_buffer, RenderTarget render_target)
    {
        command_buffer.Draw(3, 1, 0, 0);
    }

    private PostProcessingRenderPass _Parent;

    private ShaderVariant _FsVariant = new ShaderVariant();

    private AttachmentMap _InputAttachments = new AttachmentMap();
    private SampledMap _SampledImages = new SampledMap();
    private StorageImageMap _StorageImages = new StorageImageMap();

    private Array<byte> _PushConstantsData = new Array<byte>();

    private DrawFunc _DrawFunc = {PostProcessingSubpass.default_draw_func};

    private override void Prepare()
    {
        // Build all shaders upfront
        var resource_cache = RenderContext.GetDevice().GetResourceCache();
        resource_cache.RequestShaderModule(VK_SHADER_STAGE_VERTEX_BIT, get_vertex_shader());
        resource_cache.RequestShaderModule(VK_SHADER_STAGE_FRAGMENT_BIT, get_fragment_shader(), _FsVariant);
    }

    private override void Draw(CommandBuffer command_buffer)
    {
        // Get shaders from cache
        var resource_cache = command_buffer.GetDevice().GetResourceCache();
        var vert_shader_module = resource_cache.RequestShaderModule(VK_SHADER_STAGE_VERTEX_BIT, get_vertex_shader());
        var frag_shader_module = resource_cache.RequestShaderModule(VK_SHADER_STAGE_FRAGMENT_BIT, get_fragment_shader(), _FsVariant);

        Array<ShaderModule > shader_modules = new Array<ShaderModule >() {vert_shader_module, frag_shader_module};

        // Create pipeline layout and bind it
        var pipeline_layout = resource_cache.RequestPipelineLayout(shader_modules);
        command_buffer.BindPipelineLayout(pipeline_layout);

        // Disable culling
        RasterizationState rasterization_state = new RasterizationState();
        rasterization_state.CullMode = VK_CULL_MODE_NONE;
        command_buffer.SetRasterizationState(rasterization_state);

        var render_target = *_Parent.draw_render_target;
        in auto target_views = render_target.GetViews();
        uint n_input_attachments = new uint(GetInputAttachments().size());

        if (_Parent.uniform_buffer_alloc != null)
        {
            // Bind buffer to set = 0, binding = 0
            var uniform_alloc = *_Parent.uniform_buffer_alloc;
            command_buffer.BindBuffer(uniform_alloc.GetBuffer(), uniform_alloc.GetOffset(), uniform_alloc.GetSize(), 0, 0, 0);
        }

        in auto bindings = pipeline_layout.GetDescriptorSetLayout(0);

        // Bind subpass inputs to set = 0, binding = <according to name>
        foreach (in it in _InputAttachments)
        {
            if (auto layout_binding = bindings.get_layout_binding(it.first))
            {
                command_buffer.BindInput(target_views.at(it.second), 0, layout_binding.binding, 0);
            }
        }

        // Bind samplers to set = 0, binding = <according to name>
        foreach (in it in _SampledImages)
        {
            if (auto layout_binding = bindings.get_layout_binding(it.first))
            {
                in auto view = it.second.get_image_view(render_target);
                in auto sampler = it.second.get_sampler() ? *it.second.get_sampler() : *_Parent.DefaultSampler;

                command_buffer.BindImage(view, sampler, 0, layout_binding.binding, 0);
            }
        }

        // Bind storage images to set = 0, binding = <according to name>
        foreach (in it in _StorageImages)
        {
            if (auto layout_binding = bindings.get_layout_binding(it.first))
            {
                command_buffer.BindImage(it.second, 0, layout_binding.binding, 0);
            }
        }

        // Per-draw push constants
        command_buffer.PushConstants(_PushConstantsData);

        // draw full screen triangle
        draw_func(command_buffer, render_target);
    }
}

/**
* @brief A collection of vkb::PostProcessingSubpass that are run as a single renderpass.
*/
public class PostProcessingRenderPass : PostProcessingPass<PostProcessingRenderPass>
{
//    friend class PostProcessingSubpass;

    public PostProcessingRenderPass(PostProcessingPipeline parent, std::unique_ptr<Sampler> &&default_sampler = null) : base({parent})
    {
        this._DefaultSampler = std::move(_DefaultSampler);
        if (this._DefaultSampler == null)
        {
            // Setup a sane default sampler if none was passed
            VkSamplerCreateInfo sampler_info = new VkSamplerCreateInfo(VK_STRUCTURE_TYPE_SAMPLER_CREATE_INFO);
            sampler_info.minFilter = VK_FILTER_LINEAR;
            sampler_info.magFilter = VK_FILTER_LINEAR;
            sampler_info.mipmapMode = VK_SAMPLER_MIPMAP_MODE_NEAREST;
            sampler_info.addressModeU = VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE;
            sampler_info.addressModeV = VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE;
            sampler_info.addressModeW = VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE;
            sampler_info.mipLodBias = 0.0f;
            sampler_info.compareOp = VK_COMPARE_OP_NEVER;
            sampler_info.minLod = 0.0f;
            sampler_info.maxLod = 0.0f;
            sampler_info.anisotropyEnable = false;
            sampler_info.maxAnisotropy = 0.0f;
            sampler_info.borderColor = VK_BORDER_COLOR_FLOAT_OPAQUE_WHITE;

            this._DefaultSampler = std::make_unique<Sampler>(get_render_context().get_device(), sampler_info);
        }
    }

//    PostProcessingRenderPass(@in PostProcessingRenderPass to_copy) = delete;
//    PostProcessingRenderPass &operator =(@in PostProcessingRenderPass to_copy) = delete;

//    PostProcessingRenderPass(PostProcessingRenderPass &&to_move) = default;
//    PostProcessingRenderPass &operator =(PostProcessingRenderPass &&to_move) = default;

    public override void Draw(CommandBuffer command_buffer, RenderTarget default_render_target)
    {
        PrepareDraw(command_buffer, default_render_target);

        if (_UniformData.Count > 0)
        {
            // Allocate a buffer (using the buffer pool from the active frame to store uniform values) and bind it
            var render_frame = Parent.GetRenderContext().GetActiveFrame();
            _UniformBufferAlloc = new BufferAllocation(render_frame.AllocateBuffer(VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT, _UniformData.Count));
            _UniformBufferAlloc.Update(_UniformData);
        }

        // Update render target for this draw
        _DrawRenderTarget = RenderTarget != null ? RenderTarget : default_render_target;

        {
        // Set appropriate viewport & scissor for this RT
            var extent = _DrawRenderTarget.GetExtent();

            VkViewport viewport = new VkViewport();
            viewport.width = (float)extent.width;
            viewport.height = (float)extent.height;
            viewport.minDepth = 0.0f;
            viewport.maxDepth = 1.0f;
            command_buffer.SetViewport(0, new Array<VkViewport>() {viewport});

            VkRect2D scissor = new VkRect2D();
            scissor.extent = extent;
            command_buffer.SetScissor(0, new Array<VkRect2D>() {scissor});
        }

        // Finally draw all subpasses
        _Pipeline.Draw(command_buffer, _DrawRenderTarget);

        if (Parent.GetCurrentPassIndex() < (Parent.GetPasses().Count - 1))
        {
            // Leave the last renderpass open for user modification (e.g., drawing GUI)
            command_buffer.EndRenderPass();
        }
    }

    /**
    * @brief Gets the step at the given index.
    */
    public PostProcessingSubpass GetSubpass(nint index)
    {
        return _Pipeline.GetSubpasses()[index].get() as PostProcessingSubpass;
    }

    /**
     * @brief Constructs a new PostProcessingSubpass and adds it to the tail of the pipeline.
     * @remarks `this`, the render context and the vertex shader source are passed automatically before `args`.
     * @returns The inserted step.
     */
    public PostProcessingSubpass AddSubpass<ConstructorArgs>(ConstructorArgs && ... args)
    {
        ShaderSource vs_copy = get_triangle_vs();
        var new_subpass = std::make_unique<PostProcessingSubpass>(this, get_render_context(), std::move(vs_copy), std::forward<ConstructorArgs>(args)...);
        var new_subpass_ref = *new_subpass;

        _Pipeline.AddSubpass(std::move(new_subpass));

        return new_subpass_ref;
    }

    /**
     * @brief Set the uniform data to be bound at set 0, binding 0.
     */
    public PostProcessingRenderPass SetUniformData<T>(in T data)
    {
        _UniformData.Capacity = sizeof(in);
        var data_ptr = reinterpret_cast<byte>(data);
        _UniformData.assign(data_ptr, data_ptr + sizeof(in));

        return this;
    }

    /**
     * @copydoc set_uniform_data(const T&)
     */
    public PostProcessingRenderPass SetUniformData(Array<byte> data)
    {
        _UniformData = data;

        return this;
    }

    // An attachment sampled from a rendertarget

    /**
     * @brief Transition input, sampled and output attachments as appropriate.
     * @remarks If a RenderTarget is not explicitly set for this pass, fallback_render_target is used.
     */
    private void TransitionAttachments(in HashSet<uint> input_attachments, in SampledAttachmentSet sampled_attachments, in HashSet<uint> output_attachments, CommandBuffer command_buffer, RenderTarget fallback_render_target)
    {
        var render_target = this.RenderTarget != null ? this.RenderTarget : fallback_render_target;
        in auto views = render_target.GetViews();

        BarrierInfo fallback_barrier_src = new BarrierInfo();
        fallback_barrier_src.PipelineStage = VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT;
        fallback_barrier_src.ImageReadAccess = 0; // For UNDEFINED -> COLOR_ATTACHMENT_OPTIMAL in first RP
        fallback_barrier_src.ImageWriteAccess = 0;
        var prev_pass_barrier_info = get_predecessor_src_barrier_info(fallback_barrier_src);

        foreach (uint input in input_attachments)
        {
            VkImageLayout prev_layout = render_target.GetLayout(input);
            if (prev_layout == VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL)
            {
                // No-op
                continue;
            }

            GlobalMembers.EnsureSrcAccess(ref prev_pass_barrier_info.image_write_access, ref prev_pass_barrier_info.pipeline_stage, prev_layout);

            ImageMemoryBarrier barrier = new ImageMemoryBarrier();
            barrier.OldLayout = render_target.GetLayout(input);
            barrier.NewLayout = VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL;
            barrier.SrcAccessMask = prev_pass_barrier_info.image_write_access;
            barrier.DstAccessMask = VK_ACCESS_INPUT_ATTACHMENT_READ_BIT;
            barrier.SrcStageMask = prev_pass_barrier_info.pipeline_stage;
            barrier.DstStageMask = VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT;

            command_buffer.ImageMemoryBarrier(views.at(input), barrier);
            render_target.SetLayout(input, VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL);
        }

        foreach (in sampled in sampled_attachments)
        {
            var sampled_rt = sampled.first ? sampled.first : render_target;

            // unpack depth resolve flag and attachment
            bool is_depth_resolve = (sampled.second & GlobalMembers.DEPTH_RESOLVE_BITMASK) != 0;
            uint attachment = sampled.second & GlobalMembers.ATTACHMENT_BITMASK;

            var prev_layout = sampled_rt.GetLayout(attachment);

            if (prev_layout == VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL)
            {
                // No-op
                continue;
            }

            // The resolving depth occurs in the COLOR_ATTACHMENT_OUT stage, not in the EARLY\LATE_FRAGMENT_TESTS stage
            // and the corresponding access mask is COLOR_ATTACHMENT_WRITE_BIT, not DEPTH_STENCIL_ATTACHMENT_WRITE_BIT.
            if (is_depth_resolve && prev_layout == VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL)
            {
                prev_pass_barrier_info.pipeline_stage = VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT;
                prev_pass_barrier_info.image_read_access = VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT;
            }
            else
            {
                GlobalMembers.EnsureSrcAccess(ref prev_pass_barrier_info.image_read_access, ref prev_pass_barrier_info.pipeline_stage, prev_layout);
            }

            ImageMemoryBarrier barrier = new ImageMemoryBarrier();
            barrier.OldLayout = prev_layout;
            barrier.NewLayout = VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL;
            barrier.SrcAccessMask = prev_pass_barrier_info.image_read_access;
            barrier.DstAccessMask = VK_ACCESS_SHADER_READ_BIT;
            barrier.SrcStageMask = prev_pass_barrier_info.pipeline_stage;
            barrier.DstStageMask = VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT;

            command_buffer.ImageMemoryBarrier(sampled_rt.GetViews()[attachment], barrier);
            sampled_rt.SetLayout(attachment, VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL);
        }

        foreach (uint output in output_attachments)
        {
            VkFormat attachment_format = views.at(output).get_format();
            bool is_depth_stencil = is_depth_only_format(attachment_format) || is_depth_stencil_format(attachment_format);
            VkImageLayout output_layout = is_depth_stencil ? VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL : VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL;
            if (render_target.GetLayout(output) == output_layout)
            {
                // No-op
                continue;
            }

            ImageMemoryBarrier barrier = new ImageMemoryBarrier();
            barrier.OldLayout = VK_IMAGE_LAYOUT_UNDEFINED; // = don't care about previous contents
            barrier.NewLayout = output_layout;
            barrier.SrcAccessMask = 0;
            if (is_depth_stencil)
            {
                barrier.DstAccessMask = VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT | VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT;
                barrier.SrcStageMask = VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT;
                barrier.DstStageMask = VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT | VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT;
            }
            else
            {
                barrier.DstAccessMask = VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT;
                barrier.SrcStageMask = VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT;
                barrier.DstStageMask = VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT;
            }

            command_buffer.ImageMemoryBarrier(views.at(output), barrier);
            render_target.SetLayout(output, output_layout);
        }

        // NOTE: Unused attachments might be carried over to other render passes,
        //       so we don't want to transition them to UNDEFINED layout here
    }

    /**
     * @brief Select appropriate load/store operations for each buffer of render_target,
     *        according to the subpass inputs/sampled inputs/subpass outputs of all steps
     *        in the pipeline.
     * @remarks If a RenderTarget is not explicitly set for this pass, fallback_render_target is used.
     */
    private void UpdateLoadStores(in HashSet<uint> input_attachments, in SampledAttachmentSet sampled_attachments, in HashSet<uint> output_attachments, in RenderTarget fallback_render_target)
    {
        if (!_LoadStoresDirty)
        {
            return;
        }

        in auto RenderTarget = this.RenderTarget != null ? this.RenderTarget : fallback_render_target;

        // Update load/stores accordingly
        _LoadStores.Clear();

        for (uint j = 0; j < uint(RenderTarget.GetAttachments().Count); j++)
        {
            bool is_input = input_attachments.find(j) != input_attachments.end();
            bool is_sampled = std::find_if(sampled_attachments.begin(), sampled_attachments.end(), (pair) =>
            {
                var sampled_rt = pair.first ? pair.first : RenderTarget;
                uint attachment = pair.second & GlobalMembers.ATTACHMENT_BITMASK;
                return attachment == j && sampled_rt == RenderTarget;
            }) != sampled_attachments.end();
            bool is_output = output_attachments.find(j) != output_attachments.end();

            VkAttachmentLoadOp load = new VkAttachmentLoadOp();
            if (is_input || is_sampled)
            {
                load = VK_ATTACHMENT_LOAD_OP_LOAD;
            }
            else if (is_output)
            {
                load = VK_ATTACHMENT_LOAD_OP_CLEAR;
            }
            else
            {
                load = VK_ATTACHMENT_LOAD_OP_DONT_CARE;
            }

            VkAttachmentStoreOp store = new VkAttachmentStoreOp();
            if (is_output)
            {
                store = VK_ATTACHMENT_STORE_OP_STORE;
            }
            else
            {
                store = VK_ATTACHMENT_STORE_OP_DONT_CARE;
            }

            _LoadStores.Add(new LoadStoreInfo() {load_op = load, store_op = store});
        }

        _Pipeline.SetLoadStore(_LoadStores);
        _LoadStoresDirty = false;
    }

    /**
     * @brief Transition images and prepare load/stores before draw()ing.
     */
    private void PrepareDraw(CommandBuffer command_buffer, RenderTarget fallback_render_target)
    {
        // Collect all input, output, and sampled-from attachments from all subpasses (steps)
        HashSet<uint> input_attachments = new HashSet<uint>();
        HashSet<uint> output_attachments = new HashSet<uint>();
        SampledAttachmentSet sampled_attachments = new SampledAttachmentSet();

        foreach (var step_ptr in _Pipeline.GetSubpasses())
        {
            var step = *step_ptr.get() as PostProcessingSubpass;

            foreach (var it in step.get_input_attachments())
            {
                input_attachments.Add(it.second);
            }

            foreach (var it in step.get_sampled_images())
            {
                if (const uint * sampled_attachment = it.second.get_target_attachment())
                {
                    var image_rt = it.second.get_render_target();
                    var packed_sampled_attachment = *sampled_attachment;

                    // pack sampled attachment
                    if (it.second.is_depth_resolve())
                    {
                        packed_sampled_attachment |= GlobalMembers.DEPTH_RESOLVE_BITMASK;
                    }

                    sampled_attachments.insert({image_rt, packed_sampled_attachment});
                }
            }

            foreach (uint it in step.get_output_attachments())
            {
                output_attachments.Add(it);
            }
        }

        TransitionAttachments(input_attachments, sampled_attachments, output_attachments, command_buffer, fallback_render_target);
        UpdateLoadStores(input_attachments, sampled_attachments, output_attachments, fallback_render_target);
    }

    private override PostProcessingRenderPass.BarrierInfo GetSrcBarrierInfo()
    {
        BarrierInfo info = new BarrierInfo();
        info.PipelineStage = VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT;
        info.ImageReadAccess = VK_ACCESS_COLOR_ATTACHMENT_READ_BIT;
        info.ImageWriteAccess = VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT;
        return info;
    }

    private override PostProcessingRenderPass.BarrierInfo GetDstBarrierInfo()
    {
        BarrierInfo info = new BarrierInfo();
        info.PipelineStage = VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT;
        info.ImageReadAccess = VK_ACCESS_SHADER_READ_BIT;
        info.ImageWriteAccess = VK_ACCESS_SHADER_WRITE_BIT;
        return info;
    }

    private RenderPipeline _Pipeline = new RenderPipeline();
    private std::unique_ptr<Sampler> _DefaultSampler = new std::unique_ptr<core.Sampler>();
    private RenderTarget _DrawRenderTarget = new RenderTarget(null);
    private Array<LoadStoreInfo> _LoadStores = new Array<LoadStoreInfo>();
    private bool _LoadStoresDirty = true;
    private Array<byte> _UniformData = new Array<byte>();
    private BufferAllocation _UniformBufferAlloc = new BufferAllocation();
}

} // namespace vkb


namespace Vulkan.Framework
{
    //public partial class GlobalMembers
    //{
    //    public const uint DEPTH_RESOLVE_BITMASK = 0x80000000;
    //    public const uint ATTACHMENT_BITMASK    = 0x7FFFFFFF;

    //    // If the passed `src_access` is zero, guess it - and the corresponding source stage - from the src_access_mask
    //    // of the image
    //    internal static void ensure_src_access(ref uint      src_access,
    //                                           ref uint      src_stage,
    //                                           VkImageLayout layout)
    //    {
    //        if(src_access == 0)
    //        {
    //            switch(layout)
    //            {
    //                case VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL:
    //                    src_stage  =  VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT | VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT;
    //                    src_access =  VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT;
    //                    src_access |= VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT;
    //                    break;
    //                default:
    //                    src_stage  = VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT;
    //                    src_access = VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT;
    //                    break;
    //            }
    //        }
    //    }
    //}
}