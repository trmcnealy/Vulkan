using System.Collections.Generic;
using System.Diagnostics;







namespace Vulkan.Framework
{
/**
 * @brief RenderContext acts as a frame manager for the sample, with a lifetime that is the
 * same as that of the Application itself. It acts as a container for RenderFrame objects,
 * swapping between them (begin_frame, end_frame) and forwarding requests for Vulkan resources
 * to the active frame. Note that it's guaranteed that there is always an active frame.
 * More than one frame can be in-flight in the GPU, thus the need for per-frame resources.
 *
 * It requires a Device to be valid on creation, and will take control of a given Swapchain.
 *
 * For normal rendering (using a swapchain), the RenderContext can be created by passing in a
 * swapchain. A RenderFrame will then be created for each Swapchain image.
 *
 * For headless rendering (no swapchain), the RenderContext can be given a valid Device, and
 * a width and height. A single RenderFrame will then be created.
 */
public class RenderContext : System.IDisposable
{
    // The format to use for the RenderTargets if a swapchain isn't created
    public static VkFormat DefaultVkFormat = VK_FORMAT_R8G8B8A8_SRGB;

    /**
     * @brief Constructor
     * @param device A valid device
     * @param surface A surface, 0 if in headless mode
     * @param window_width The width of the window where the surface was created
     * @param window_height The height of the window where the surface was created
     */
    public RenderContext(Device device, VkSurfaceKHR surface, uint window_width, uint window_height)
    {
        this._Device = new Device(device);
        this.queue = device.GetSuitableGraphicsQueue();
        this.SurfaceExtent = new VkExtent2D(window_width, window_height);
        if (surface != 0)
        {
            VkSurfaceCapabilitiesKHR surface_properties = new VkSurfaceCapabilitiesKHR();
            do
            {
                VkResult err = vkGetPhysicalDeviceSurfaceCapabilitiesKHR(device.GetGpu().GetHandle(), surface, surface_properties);
                if (err != null)
                {
                    (...) spdlog.error("[{}:{}] {}", ((char)__FILE__ + ROOT_PATH_SIZE), __LINE__, fmt.format(__VA_ARGS__));
                    ("Detected Vulkan error: {}", GlobalMembers.ToString(err));
                    abort();
                }
            } while (false);

            if (surface_properties.currentExtent.width == 0xFFFFFFFF)
            {
                _Swapchain = std::make_unique<Swapchain>(device, surface, SurfaceExtent);
            }
            else
            {
                _Swapchain = std::make_unique<Swapchain>(device, surface);
            }
        }
    }

//    RenderContext(@in RenderContext) = delete;

//    RenderContext(RenderContext &&) = delete;

//    virtual ~RenderContext() = default;

//    RenderContext &operator =(@in RenderContext) = delete;

//    RenderContext &operator =(RenderContext &&) = delete;

    /**
     * @brief Requests to set the present mode of the swapchain, must be called before prepare
     */
    public void RequestPresentMode(VkPresentModeKHR present_mode)
    {
        if (_Swapchain != null)
        {
            var properties = _Swapchain.get_properties();
            properties.present_mode = present_mode;
        }
    }

    /**
     * @brief Requests to set a specific image format for the swapchain
     */
    public void RequestImageFormat(VkFormat format)
    {
        if (_Swapchain != null)
        {
            var properties = _Swapchain.get_properties();
            properties.surface_format.format = format;
        }
    }

    /**
     * @brief Sets the order in which the swapchain prioritizes selecting its present mode
     */
    public void SetPresentModePriority(Array<VkPresentModeKHR> new_present_mode_priority_list)
    {
        Debug.Assert(new_present_mode_priority_list.Count > 0 && "Priority list must not be empty");
        _PresentModePriorityList = new_present_mode_priority_list;
    }

    /**
     * @brief Sets the order in which the swapchain prioritizes selecting its surface format
     */
    public void SetSurfaceFormatPriority(Array<VkSurfaceFormatKHR> new_surface_format_priority_list)
    {
        Debug.Assert(new_surface_format_priority_list.Count > 0 && "Priority list must not be empty");
        _SurfaceFormatPriorityList = new_surface_format_priority_list;
    }

    /**
     * @brief Prepares the RenderFrames for rendering
     * @param thread_count The number of threads in the application, necessary to allocate this many resource pools for each RenderFrame
     * @param create_render_target_func A function delegate, used to create a RenderTarget
     */
    public void Prepare(nint thread_count = 1, RenderTarget.CreateFunc create_render_target_func = RenderTarget.DEFAULT_CREATE_FUNC)
    {
        _Device.WaitIdle();

        if (_Swapchain != null)
        {
            _Swapchain.set_present_mode_priority(_PresentModePriorityList);
            _Swapchain.set_surface_format_priority(_SurfaceFormatPriorityList);
            _Swapchain.create();

            SurfaceExtent = _Swapchain.get_extent();

            VkExtent3D extent = new VkExtent3D(SurfaceExtent.width, SurfaceExtent.height, 1);

            foreach (var image_handle in _Swapchain.get_images())
            {
                var swapchain_image = new Image({_Device, image_handle, extent, _Swapchain.get_format(), _Swapchain.get_usage()});
                var render_target = create_render_target_func(std::move(swapchain_image));
                _Frames.emplace_back(std::make_unique<RenderFrame>(_Device, std::move(render_target), thread_count));
            }
        }
        else
        {
            // Otherwise, create a single RenderFrame
            _Swapchain = null;

            var color_image = new Image({_Device, VkExtent3D({SurfaceExtent.width, SurfaceExtent.height, 1}), DefaultVkFormat, VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT | VK_IMAGE_USAGE_TRANSFER_SRC_BIT, VMA_MEMORY_USAGE_GPU_ONLY});

            var render_target = create_render_target_func(std::move(color_image));
            _Frames.emplace_back(std::make_unique<RenderFrame>(_Device, std::move(render_target), thread_count));
        }

        this._CreateRenderTargetFunc = create_render_target_func;
        this._ThreadCount = thread_count;
        this._Prepared = true;
    }

    /**
     * @brief Updates the swapchains extent, if a swapchain exists
     * @param extent The width and height of the new swapchain images
     */
    public void UpdateSwapchain(in VkExtent2D extent)
    {
        if (_Swapchain == null)
        {
            (...) spdlog.warn(__VA_ARGS__);
            ("Can't update the swapchains extent in headless mode, skipping.");
            return;
        }

        _Device.GetResourceCache().ClearFramebuffers();

        _Swapchain = std::make_unique<Swapchain>(*_Swapchain, extent);

        Recreate();
    }

    /**
     * @brief Updates the swapchains image count, if a swapchain exists
     * @param image_count The amount of images in the new swapchain
     */
    public void UpdateSwapchain(uint image_count)
    {
        if (_Swapchain == null)
        {
            (...) spdlog.warn(__VA_ARGS__);
            ("Can't update the swapchains image count in headless mode, skipping.");
            return;
        }

        _Device.GetResourceCache().ClearFramebuffers();

        _Device.WaitIdle();

        _Swapchain = std::make_unique<Swapchain>(*_Swapchain, image_count);

        Recreate();
    }

    /**
     * @brief Updates the swapchains image usage, if a swapchain exists
     * @param image_usage_flags The usage flags the new swapchain images will have
     */
    public void UpdateSwapchain(SortedSet<VkImageUsageFlagBits> image_usage_flags)
    {
        if (_Swapchain == null)
        {
            (...) spdlog.warn(__VA_ARGS__);
            ("Can't update the swapchains image usage in headless mode, skipping.");
            return;
        }

        _Device.GetResourceCache().ClearFramebuffers();

        _Swapchain = std::make_unique<Swapchain>(*_Swapchain, image_usage_flags);

        Recreate();
    }

    /**
     * @brief Updates the swapchains extent and surface transform, if a swapchain exists
     * @param extent The width and height of the new swapchain images
     * @param transform The surface transform flags
     */
    public void UpdateSwapchain(in VkExtent2D extent, VkSurfaceTransformFlagBitsKHR transform)
    {
        if (_Swapchain == null)
        {
            (...) spdlog.warn(__VA_ARGS__);
            ("Can't update the swapchains extent and surface transform in headless mode, skipping.");
            return;
        }

        _Device.GetResourceCache().ClearFramebuffers();

        var width = extent.width;
        var height = extent.height;
        if (transform == VK_SURFACE_TRANSFORM_ROTATE_90_BIT_KHR || transform == VK_SURFACE_TRANSFORM_ROTATE_270_BIT_KHR)
        {
            // Pre-rotation: always use native orientation i.e. if rotated, use width and height of identity transform
            std::swap(width, height);
        }

        _Swapchain = std::make_unique<Swapchain>(*_Swapchain, VkExtent2D({width, height}), transform);

        // Save the preTransform attribute for future rotations
        _PreTransform = transform;

        Recreate();
    }

    /**
     * @returns True if a valid swapchain exists in the RenderContext
     */
    public bool HasSwapchain()
    {
        return _Swapchain != null;
    }

    /**
     * @brief Recreates the RenderFrames, called after every update
     */
    public void Recreate()
    {
        (...) spdlog.info(__VA_ARGS__);
        ("Recreated swapchain");

        VkExtent2D swapchain_extent = _Swapchain.get_extent();
        VkExtent3D extent = new VkExtent3D(swapchain_extent.width, swapchain_extent.height, 1);

        var frame_it = _Frames.GetEnumerator();

        foreach (var image_handle in _Swapchain.get_images())
        {
            Image swapchain_image = new Image(_Device, image_handle, extent, _Swapchain.get_format(), _Swapchain.get_usage());

            var render_target = create_render_target_func(std::move(swapchain_image));

            if (frame_it != _Frames.end())
            {
                (frame_it).update_render_target(std::move(render_target));
            }
            else
            {
                // Create a new frame if the new swapchain has more images than current frames
                _Frames.emplace_back(std::make_unique<RenderFrame>(_Device, std::move(render_target), _ThreadCount));
            }

            ++frame_it;
        }

        _Device.GetResourceCache().ClearFramebuffers();
    }

    /**
     * @brief Recreates the swapchain
     */
    public void RecreateSwapchain()
    {
        _Device.WaitIdle();
        _Device.GetResourceCache().ClearFramebuffers();

        VkExtent2D swapchain_extent = _Swapchain.get_extent();
        VkExtent3D extent = new VkExtent3D(swapchain_extent.width, swapchain_extent.height, 1);

        var frame_it = _Frames.GetEnumerator();

        foreach (var image_handle in _Swapchain.get_images())
        {
            Image swapchain_image = new Image(_Device, image_handle, extent, _Swapchain.get_format(), _Swapchain.get_usage());

            var render_target = create_render_target_func(std::move(swapchain_image));
            (frame_it).update_render_target(std::move(render_target));

            ++frame_it;
        }
    }

    /**
     * @brief Prepares the next available frame for rendering
     * @param reset_mode How to reset the command buffer
     * @returns A valid command buffer to record commands to be submitted
     * Also ensures that there is an active frame if there is no existing active frame already
     */
    public CommandBuffer Begin(CommandBuffer.ResetMode reset_mode = CommandBuffer.ResetMode.ResetPool)
    {
        Debug.Assert(_Prepared && "RenderContext not prepared for rendering, call prepare()");

        if (!_FrameActive)
        {
            BeginFrame();
        }

        if (_AcquiredSemaphore == 0)
        {
            throw new System.Exception("Couldn't begin frame");
        }

        in auto queue = _Device.GetQueueByFlagBits(VK_QUEUE_GRAPHICS_BIT, 0);
        return GetActiveFrame().RequestCommandBuffer(queue, reset_mode);
    }

    /**
     * @brief Submits the command buffer to the right queue
     * @param command_buffer A command buffer containing recorded commands
     */
    public void Submit(CommandBuffer command_buffer)
    {
        submit({command_buffer});
    }

    /**
     * @brief Submits multiple command buffers to the right queue
     * @param command_buffers Command buffers containing recorded commands
     */
    public void Submit(Array<CommandBuffer > command_buffers)
    {
        Debug.Assert(_FrameActive && "RenderContext is inactive, cannot submit command buffer. Please call begin()");

        VkSemaphore render_semaphore = 0;

        if (_Swapchain != null)
        {
            Debug.Assert(_AcquiredSemaphore && "We do not have acquired_semaphore, it was probably consumed?\n");
            render_semaphore = Submit(queue, command_buffers, _AcquiredSemaphore, VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT);
        }
        else
        {
            Submit(queue, command_buffers);
        }

        EndFrame(render_semaphore);
    }

    /**
     * @brief begin_frame
     */
    public void BeginFrame()
    {
        // Only handle surface changes if a swapchain exists
        if (_Swapchain != null)
        {
            HandleSurfaceChanges();
        }

        Debug.Assert(!_FrameActive && "Frame is still active, please call end_frame");

        var prev_frame = *_Frames[_ActiveFrameIndex];

        // We will use the acquired semaphore in a different frame context,
        // so we need to hold ownership.
        _AcquiredSemaphore = prev_frame.request_semaphore_with_ownership();

        if (_Swapchain != null)
        {
            var result = _Swapchain.acquire_next_image(_ActiveFrameIndex, _AcquiredSemaphore, 0);

            if (result == VK_SUBOPTIMAL_KHR || result == VK_ERROR_OUT_OF_DATE_KHR)
            {
                bool swapchain_updated = HandleSurfaceChanges(result == VK_ERROR_OUT_OF_DATE_KHR);

                if (swapchain_updated)
                {
                    result = _Swapchain.acquire_next_image(_ActiveFrameIndex, _AcquiredSemaphore, 0);
                }
            }

            if (result != VK_SUCCESS)
            {
                prev_frame.reset();
                return;
            }
        }

        // Now the frame is active again
        _FrameActive = true;

        // Wait on all resource to be freed from the previous render to this frame
        WaitFrame();
    }

    public VkSemaphore Submit(in Queue queue, Array<CommandBuffer > command_buffers, VkSemaphore wait_semaphore, VkPipelineStageFlagBits wait_pipeline_stage)
    {
        Array<VkCommandBuffer> cmd_buf_handles = new Array<VkCommandBuffer>(command_buffers.Count, 0);
        std::transform(command_buffers.GetEnumerator(), command_buffers.end(), cmd_buf_handles.GetEnumerator(), (CommandBuffer cmd_buf) =>
        {
            return cmd_buf.GetHandle();
        });

        RenderFrame frame = GetActiveFrame();

        VkSemaphore signal_semaphore = frame.RequestSemaphore();

        VkSubmitInfo submit_info = new VkSubmitInfo(VK_STRUCTURE_TYPE_SUBMIT_INFO);

        submit_info.commandBufferCount = GlobalMembers.ToU32(cmd_buf_handles.Count);
        submit_info.pCommandBuffers = cmd_buf_handles.data();

        if (wait_semaphore != 0)
        {
            submit_info.waitSemaphoreCount = 1;
            submit_info.pWaitSemaphores = wait_semaphore;
            submit_info.pWaitDstStageMask = wait_pipeline_stage;
        }

        submit_info.signalSemaphoreCount = 1;
        submit_info.pSignalSemaphores = signal_semaphore;

        VkFence fence = frame.RequestFence();

        queue.submit({submit_info}, fence);

        return signal_semaphore;
    }

    /**
     * @brief Submits a command buffer related to a frame to a queue
     */
    public void Submit(in Queue queue, Array<CommandBuffer > command_buffers)
    {
        Array<VkCommandBuffer> cmd_buf_handles = new Array<VkCommandBuffer>(command_buffers.Count, 0);
        std::transform(command_buffers.GetEnumerator(), command_buffers.end(), cmd_buf_handles.GetEnumerator(), (CommandBuffer cmd_buf) =>
        {
            return cmd_buf.GetHandle();
        });

        RenderFrame frame = GetActiveFrame();

        VkSubmitInfo submit_info = new VkSubmitInfo(VK_STRUCTURE_TYPE_SUBMIT_INFO);

        submit_info.commandBufferCount = GlobalMembers.ToU32(cmd_buf_handles.Count);
        submit_info.pCommandBuffers = cmd_buf_handles.data();

        VkFence fence = frame.RequestFence();

        queue.submit({submit_info}, fence);
    }

    /**
     * @brief Waits a frame to finish its rendering
     */
    public virtual void WaitFrame()
    {
        RenderFrame frame = GetActiveFrame();
        frame.Reset();
    }

    public void EndFrame(VkSemaphore semaphore)
    {
        Debug.Assert(_FrameActive && "Frame is not active, please call begin_frame");

        if (_Swapchain != null)
        {
            VkSwapchainKHR vk_swapchain = _Swapchain.get_handle();

            VkPresentInfoKHR present_info = new VkPresentInfoKHR(VK_STRUCTURE_TYPE_PRESENT_INFO_KHR);

            present_info.waitSemaphoreCount = 1;
            present_info.pWaitSemaphores = semaphore;
            present_info.swapchainCount = 1;
            present_info.pSwapchains = vk_swapchain;
            present_info.pImageIndices = _ActiveFrameIndex;

            VkResult result = queue.present(present_info);

            if (result == VK_SUBOPTIMAL_KHR || result == VK_ERROR_OUT_OF_DATE_KHR)
            {
                HandleSurfaceChanges();
            }
        }

        // Frame is not active anymore
        if (_AcquiredSemaphore != null)
        {
            ReleaseOwnedSemaphore(_AcquiredSemaphore);
            _AcquiredSemaphore = 0;
        }
        _FrameActive = false;
    }

    /**
     * @brief An error should be raised if the frame is not active.
     *        A frame is active after @ref begin_frame has been called.
     * @return The current active frame
     */
    public RenderFrame GetActiveFrame()
    {
        Debug.Assert(_FrameActive && "Frame is not active, please call begin_frame");
        return _Frames[_ActiveFrameIndex];
    }

    /**
     * @brief An error should be raised if the frame is not active.
     *        A frame is active after @ref begin_frame has been called.
     * @return The current active frame index
     */
    public uint GetActiveFrameIndex()
    {
        Debug.Assert(_FrameActive && "Frame is not active, please call begin_frame");
        return _ActiveFrameIndex;
    }

    /**
     * @brief An error should be raised if a frame is active.
     *        A frame is active after @ref begin_frame has been called.
     * @return The previous frame
     */
    public RenderFrame GetLastRenderedFrame()
    {
        Debug.Assert(!_FrameActive && "Frame is still active, please call end_frame");
        return _Frames[_ActiveFrameIndex];
    }

    public VkSemaphore RequestSemaphore()
    {
        RenderFrame frame = GetActiveFrame();
        return frame.RequestSemaphore();
    }

    public VkSemaphore RequestSemaphoreWithOwnership()
    {
        RenderFrame frame = GetActiveFrame();
        return frame.RequestSemaphoreWithOwnership();
    }

    public void ReleaseOwnedSemaphore(VkSemaphore semaphore)
    {
        RenderFrame frame = GetActiveFrame();
        frame.ReleaseOwnedSemaphore(semaphore);
    }

    public Device GetDevice()
    {
        return _Device;
    }

    /**
     * @brief Returns the format that the RenderTargets are created with within the RenderContext
     */
    public VkFormat GetFormat()
    {
        VkFormat format = DefaultVkFormat;

        if (_Swapchain != null)
        {
            format = _Swapchain.get_format();
        }

        return format;
    }

    public Swapchain GetSwapchain()
    {
        Debug.Assert(_Swapchain && "Swapchain is not valid");
        return _Swapchain;
    }

    public VkExtent2D GetSurfaceExtent()
    {
        return SurfaceExtent;
    }

    public uint GetActiveFrameIndex()
    {
        return _ActiveFrameIndex;
    }

    public Array<std::unique_ptr<RenderFrame>> GetRenderFrames()
    {
        return _Frames;
    }

    /**
     * @brief Handles surface changes, only applicable if the render_context makes use of a swapchain
     */
    public virtual bool HandleSurfaceChanges(bool force_update = false)
    {
        if (_Swapchain == null)
        {
            (...) spdlog.warn(__VA_ARGS__);
            ("Can't handle surface changes in headless mode, skipping.");
            return false;
        }

        VkSurfaceCapabilitiesKHR surface_properties = new VkSurfaceCapabilitiesKHR();
        do
        {
            VkResult err = vkGetPhysicalDeviceSurfaceCapabilitiesKHR(_Device.GetGpu().GetHandle(), _Swapchain.get_surface(), surface_properties);
            if (err != null)
            {
                (...) spdlog.error("[{}:{}] {}", ((char)__FILE__ + ROOT_PATH_SIZE), __LINE__, fmt.format(__VA_ARGS__));
                ("Detected Vulkan error: {}", GlobalMembers.ToString(err));
                abort();
            }
        } while (false);

        if (surface_properties.currentExtent.width == 0xFFFFFFFF)
        {
            return false;
        }

        // Only recreate the swapchain if the dimensions have changed;
        // handle_surface_changes() is called on VK_SUBOPTIMAL_KHR,
        // which might not be due to a surface resize
        if (surface_properties.currentExtent.width != SurfaceExtent.width || surface_properties.currentExtent.height != SurfaceExtent.height || force_update)
        {
            // Recreate swapchain
            _Device.WaitIdle();

            UpdateSwapchain(surface_properties.currentExtent, _PreTransform);

            SurfaceExtent = surface_properties.currentExtent;

            return true;
        }

        return false;
    }

    /**
     * @brief Returns the WSI acquire semaphore. Only to be used in very special circumstances.
     * @return The WSI acquire semaphore.
     */
    public VkSemaphore ConsumeAcquiredSemaphore()
    {
        Debug.Assert(_FrameActive && "Frame is not active, please call begin_frame");
        var sem = _AcquiredSemaphore;
        _AcquiredSemaphore = 0;
        return sem;
    }

    protected VkExtent2D SurfaceExtent = new VkExtent2D();

    private Device _Device;

    /// If swapchain exists, then this will be a present supported queue, else a graphics queue
    private in Queue queue = new in();

    private std::unique_ptr<Swapchain> _Swapchain = new std::unique_ptr<Swapchain>();

    private SwapchainProperties _SwapchainProperties = new SwapchainProperties();

    // A list of present modes in order of priority (vector[0] has high priority, vector[size-1] has low priority)
    private Array<VkPresentModeKHR> _PresentModePriorityList = new Array<VkPresentModeKHR>() {VK_PRESENT_MODE_FIFO_KHR, VK_PRESENT_MODE_MAILBOX_KHR};

    // A list of surface formats in order of priority (vector[0] has high priority, vector[size-1] has low priority)
    private Array<VkSurfaceFormatKHR> _SurfaceFormatPriorityList = new Array<VkSurfaceFormatKHR>()
    {
        {VK_FORMAT_R8G8B8A8_SRGB, VK_COLOR_SPACE_SRGB_NONLINEAR_KHR},
        {VK_FORMAT_B8G8R8A8_SRGB, VK_COLOR_SPACE_SRGB_NONLINEAR_KHR},
        {VK_FORMAT_R8G8B8A8_UNORM, VK_COLOR_SPACE_SRGB_NONLINEAR_KHR},
        {VK_FORMAT_B8G8R8A8_UNORM, VK_COLOR_SPACE_SRGB_NONLINEAR_KHR}
    };

    private Array<std::unique_ptr<RenderFrame>> _Frames = new Array<std::unique_ptr<RenderFrame>>();

    private VkSemaphore _AcquiredSemaphore = new VkSemaphore();

    private bool _Prepared = false;

    /// Current active frame index
    private uint _ActiveFrameIndex = new uint();

    /// Whether a frame is active or not
    private bool _FrameActive = false;

    private RenderTarget.CreateFunc _CreateRenderTargetFunc = RenderTarget.DEFAULT_CREATE_FUNC;

    private VkSurfaceTransformFlagBitsKHR _PreTransform = new VkSurfaceTransformFlagBitsKHR(VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR);

    private nint _ThreadCount = new nint(1);
}

} // namespace vkb




