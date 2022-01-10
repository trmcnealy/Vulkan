using System.Collections.Generic;





namespace Vulkan.Framework
{
/**
 * @brief Maps in-shader binding names to the core::SampledImage to bind.
 */

/**
* @brief A compute pass in a vkb::PostProcessingPipeline.
*/
public class PostProcessingComputePass : PostProcessingPass<PostProcessingComputePass>
{
    public PostProcessingComputePass(PostProcessingPipeline parent, in ShaderSource cs_source, in ShaderVariant cs_variant = new in(), Sampler * &&default_sampler = {}) : base({parent})
    {
        this._CsSource = cs_source;
        this._CsVariant = cs_variant;
        this._DefaultSampler = new Sampler(std::move(_DefaultSampler));
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

            this._DefaultSampler = new Sampler(get_render_context().get_device(), sampler_info);
        }
    }

//    PostProcessingComputePass(@in PostProcessingComputePass to_copy) = delete;
//    PostProcessingComputePass &operator =(@in PostProcessingComputePass to_copy) = delete;

//    PostProcessingComputePass(PostProcessingComputePass &&to_move) = default;
//    PostProcessingComputePass &operator =(PostProcessingComputePass &&to_move) = default;

    public override void Prepare(CommandBuffer command_buffer, RenderTarget default_render_target)
    {
        // Build the compute shader upfront
        var resource_cache = get_render_context().get_device().get_resource_cache();
        resource_cache.request_shader_module(VK_SHADER_STAGE_COMPUTE_BIT, _CsSource, _CsVariant);
    }

    public override void Draw(CommandBuffer command_buffer, RenderTarget default_render_target)
    {
        TransitionImages(command_buffer, default_render_target);

        // Get compute shader from cache
        var resource_cache = command_buffer.GetDevice().GetResourceCache();
        var shader_module = resource_cache.RequestShaderModule(VK_SHADER_STAGE_COMPUTE_BIT, _CsSource, _CsVariant);

        // Create pipeline layout and bind it
        var pipeline_layout = resource_cache.RequestPipelineLayout(new Array<ShaderModule >() {shader_module});
        command_buffer.BindPipelineLayout(pipeline_layout);

        in auto bindings = pipeline_layout.GetDescriptorSetLayout(0);

        // Bind samplers to set = 0, binding = <according to name>
        foreach (in it in _SampledImages)
        {
            if (auto layout_binding = bindings.get_layout_binding(it.first))
            {
                in auto view = it.second.get_image_view(default_render_target);
                in auto sampler = it.second.get_sampler() ? *it.second.get_sampler() : *_DefaultSampler;

                command_buffer.BindImage(view, sampler, 0, layout_binding.binding, 0);
            }
        }

        // Bind storage images to set = 0, binding = <according to name>
        foreach (in it in _StorageImages)
        {
            if (auto layout_binding = bindings.get_layout_binding(it.first))
            {
                in auto view = it.second.get_image_view(default_render_target);
                command_buffer.BindImage(view, 0, layout_binding.binding, 0);
            }
        }

        if (_UniformData.Count > 0)
        {
            var render_frame = Parent.GetRenderContext().GetActiveFrame();

            _UniformAlloc = std::make_unique<BufferAllocation>(render_frame.AllocateBuffer(VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT, _UniformData.Count));
            _UniformAlloc.update(_UniformData);

            // Bind buffer to set = 0, binding = 0
            command_buffer.BindBuffer(_UniformAlloc.get_buffer(), _UniformAlloc.get_offset(), _UniformAlloc.get_size(), 0, 0, 0);
        }

        if (_PushConstantsData.Count > 0)
        {
            command_buffer.PushConstants(_PushConstantsData);
        }

        // Dispatch compute
        command_buffer.Dispatch(_NWorkgroups.x, _NWorkgroups.y, _NWorkgroups.z);
    }

    /**
     * @brief Sets the number of workgroups to be dispatched each draw().
     */
    public PostProcessingComputePass SetDispatchSize(glm.tvec3<uint> new_size)
    {
        _NWorkgroups = new_size;
        return this;
    }

    /**
     * @brief Gets the number of workgroups that will be dispatched each draw().
     */
    public glm.tvec3<uint> GetDispatchSize()
    {
        return _NWorkgroups;
    }

    /**
    * @brief Maps the names of samplers in the shader to vkb::core::SampledImage.
    *        These are given as samplers to the subpass, at set 0; they are bound automatically according to their name.
    * @remarks PostProcessingPipeline::get_sampler() is used as the default sampler if none is specified.
    *          The RenderTarget for the current PostprocessingStep is used if none is specified for attachment images.
    */
    public SampledImageMap GetSampledImages()
    {
        return _SampledImages;
    }

    /**
    * @brief Maps the names of storage images in the shader to vkb::core::SampledImage.
    *        These are given as image2D / image2DArray / ... to the subpass, at set 0;
    *        they are bound automatically according to their name.
    */
    public SampledImageMap GetStorageImages()
    {
        return _StorageImages;
    }

    /**
     * @brief Changes (or adds) the sampled image at name for this step.
     * @remarks If no RenderTarget is specifically set for the core::SampledImage,
     *          it will default to sample in the RenderTarget currently bound for drawing in the parent PostProcessingRenderpass.
     * @remarks Images from RenderTarget attachments are automatically transitioned to SHADER_READ_ONLY_OPTIMAL layout if needed.
     */
    public PostProcessingComputePass BindSampledImage(utf8string name, SampledImage && new_image)
    {
        var it = _SampledImages.find(name);
        if (it != _SampledImages.end())
        {
            it.second = new_image;
        }
        else
        {
            _SampledImages.emplace(name, new_image);
        }

        return this;
    }

    /**
     * @brief Changes (or adds) the storage image at name for this step.
     * @remarks Images from RenderTarget attachments are automatically transitioned to GENERAL layout if needed.
     */
    public PostProcessingComputePass BindStorageImage(utf8string name, SampledImage && new_image)
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
     * @brief Set the uniform data to be bound at set 0, binding 0.
     */
    public PostProcessingComputePass SetUniformData<T>(in T data)
    {
        _UniformData.Capacity = sizeof(in);
        var data_ptr = reinterpret_cast<byte>(data);
        _UniformData.assign(data_ptr, data_ptr + sizeof(in));

        return this;
    }

    /**
     * @copydoc set_uniform_data(const T&)
     */
    public PostProcessingComputePass SetUniformData(Array<byte> data)
    {
        _UniformData = data;

        return this;
    }

    /**
     * @brief Set the constants that are pushed before each draw.
     */
    public PostProcessingComputePass SetPushConstants<T>(in T data)
    {
        _PushConstantsData.Capacity = sizeof(in);
        var data_ptr = reinterpret_cast<byte>(data);
        _PushConstantsData.assign(data_ptr, data_ptr + sizeof(in));

        return this;
    }

    /**
     * @copydoc set_push_constants(const T&)
     */
    public PostProcessingComputePass SetPushConstants(Array<byte> data)
    {
        _PushConstantsData = data;

        return this;
    }

    private ShaderSource _CsSource = new ShaderSource();
    private ShaderVariant _CsVariant = new ShaderVariant();
    private glm.tvec3<uint> _NWorkgroups = new glm.tvec3<uint>(1, 1, 1);

    private Sampler _DefaultSampler = new Sampler();
    private SampledImageMap _SampledImages = new SampledImageMap();
    private SampledImageMap _StorageImages = new SampledImageMap();

    private Array<byte> _UniformData = new Array<byte>();
    private std::unique_ptr<BufferAllocation> _UniformAlloc = new std::unique_ptr<BufferAllocation>();
    private Array<byte> _PushConstantsData = new Array<byte>();

    /**
     * @brief Transitions sampled_images (to SHADER_READ_ONLY_OPTIMAL)
     *        and storage_images (to GENERAL) as appropriate.
     */
    private void TransitionImages(CommandBuffer command_buffer, RenderTarget default_render_target)
    {
        BarrierInfo fallback_barrier_src = new BarrierInfo();
        fallback_barrier_src.PipelineStage = VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT;
        fallback_barrier_src.ImageReadAccess = 0; // For UNDEFINED -> STORAGE in first CP
        fallback_barrier_src.ImageWriteAccess = 0;
        var prev_pass_barrier_info = get_predecessor_src_barrier_info(fallback_barrier_src);

        // Get compute shader from cache
        var resource_cache = command_buffer.GetDevice().GetResourceCache();
        var shader_module = resource_cache.RequestShaderModule(VK_SHADER_STAGE_COMPUTE_BIT, _CsSource, _CsVariant);
        var pipeline_layout = resource_cache.RequestPipelineLayout(new Array<ShaderModule >() {shader_module});

        foreach (in sampled in _SampledImages)
        {
            if (const uint * attachment = sampled.second.get_target_attachment())
            {
                var sampled_rt = sampled.second.get_render_target();
                if (sampled_rt == null)
                {
                    sampled_rt = default_render_target;
                }

                if (sampled_rt.get_layout(*attachment) == VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL)
                {
                    // No-op
                    continue;
                }

                ImageMemoryBarrier barrier = new ImageMemoryBarrier();
                barrier.OldLayout = sampled_rt.get_layout(*attachment);
                barrier.NewLayout = VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL;
                barrier.SrcAccessMask = prev_pass_barrier_info.image_write_access;
                barrier.DstAccessMask = VK_ACCESS_SHADER_READ_BIT;
                barrier.SrcStageMask = prev_pass_barrier_info.pipeline_stage;
                barrier.DstStageMask = VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT;

                command_buffer.ImageMemoryBarrier(sampled_rt.get_views().at(*attachment), barrier);
                sampled_rt.set_layout(*attachment, VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL);
            }
        }

        in auto bindings = pipeline_layout.GetDescriptorSetLayout(0);

        foreach (in storage in _StorageImages)
        {
            if (const uint * attachment = storage.second.get_target_attachment())
            {
                var storage_rt = storage.second.get_render_target();
                if (storage_rt == null)
                {
                    storage_rt = default_render_target;
                }

                // A storage image is either readonly or writeonly;
                // use shader reflection to figure out which case, then transition
                // NOTE: Could add a <name -> readonly?> cache to make this faster?
                var resource = std::find_if(pipeline_layout.GetResources().GetEnumerator(), pipeline_layout.GetResources().end(), (in auto res) =>
                {
                    return res.set == 0 && res.name == storage.first;
                });
                if (resource == pipeline_layout.GetResources().end())
                {
                    // No such storage image to bind
                    continue;
                }

                bool readable = (resource.qualifiers & ShaderResourceQualifiers.NonReadable) == 0;
                bool writable = (resource.qualifiers & ShaderResourceQualifiers.NonReadable) == 0;

                ImageMemoryBarrier barrier = new ImageMemoryBarrier();
                barrier.OldLayout = storage_rt.get_layout(*attachment);
                barrier.NewLayout = (readable && !writable) ? VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL : VK_IMAGE_LAYOUT_GENERAL;

                if (storage_rt.get_layout(*attachment) == barrier.NewLayout)
                {
                    // No-op
                    continue;
                }

                barrier.SrcStageMask = prev_pass_barrier_info.pipeline_stage;
                barrier.DstStageMask = VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT;

                barrier.SrcAccessMask = prev_pass_barrier_info.image_write_access;
                barrier.DstAccessMask = 0;
                if (readable)
                {
                    barrier.DstAccessMask |= VK_ACCESS_SHADER_READ_BIT;
                }
                if (writable)
                {
                    barrier.DstAccessMask |= VK_ACCESS_SHADER_WRITE_BIT;
                }

                command_buffer.ImageMemoryBarrier(storage_rt.get_views().at(*attachment), barrier);
                storage_rt.set_layout(*attachment, barrier.NewLayout);
            }
        }
    }

    private override PostProcessingComputePass.BarrierInfo GetSrcBarrierInfo()
    {
        BarrierInfo info = new BarrierInfo();
        info.PipelineStage = VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT;
        info.ImageReadAccess = VK_ACCESS_SHADER_READ_BIT;
        info.ImageWriteAccess = VK_ACCESS_SHADER_WRITE_BIT;
        return info;
    }

    private override PostProcessingComputePass.BarrierInfo GetDstBarrierInfo()
    {
        BarrierInfo info = new BarrierInfo();
        info.PipelineStage = VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT;
        info.ImageReadAccess = VK_ACCESS_SHADER_READ_BIT;
        info.ImageWriteAccess = VK_ACCESS_SHADER_WRITE_BIT;
        return info;
    }
}

} // namespace vkb



