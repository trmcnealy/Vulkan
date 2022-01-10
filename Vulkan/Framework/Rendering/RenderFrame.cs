using System;
using System.Collections.Generic;
using System.Diagnostics;







namespace Vulkan.Framework
{
    /**
 * @brief RenderFrame is a container for per-frame data, including BufferPool objects,
 * synchronization primitives (semaphores, fences) and the swapchain RenderTarget.
 *
 * When creating a RenderTarget, we need to provide images that will be used as attachments
 * within a RenderPass. The RenderFrame is responsible for creating a RenderTarget using
 * RenderTarget::CreateFunc. A custom RenderTarget::CreateFunc can be provided if a different
 * render target is required.
 *
 * A RenderFrame cannot be destroyed individually since frames are managed by the RenderContext,
 * the whole context must be destroyed. This is because each RenderFrame holds Vulkan objects
 * such as the swapchain image.
 */
public class RenderFrame
{
    /**
     * @brief Block size of a buffer pool in kilobytes
     */
    public const uint BUFFER_POOL_BLOCK_SIZE = 256;

    // A map of the supported usages to a multiplier for the BUFFER_POOL_BLOCK_SIZE
    public readonly Dictionary<VkBufferUsageFlagBits, uint> SupportedUsageMap = new Dictionary<VkBufferUsageFlagBits, uint>()
    {
        {VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT, 1},
        {VK_BUFFER_USAGE_STORAGE_BUFFER_BIT, 2},
        {VK_BUFFER_USAGE_VERTEX_BUFFER_BIT, 1},
        {VK_BUFFER_USAGE_INDEX_BUFFER_BIT, 1}
    };

    public RenderFrame(Device device, std::unique_ptr<RenderTarget> &&render_target, nint thread_count = 1)
    {
        this._Device = new Device(device);
        this._FencePool = new FencePool(device);
        this._SemaphorePool = new SemaphorePool(device);
        this._SwapchainRenderTarget = std::move(render_target);
        this._ThreadCount = thread_count;
        foreach (var usage_it in SupportedUsageMap)
        {
            Array<Tuple<BufferPool, BufferBlock >> usage_buffer_pools = new Array<Tuple<BufferPool, BufferBlock >>();
            for (nint i = 0; i < thread_count; ++i)
            {
                usage_buffer_pools.Add(Tuple.Create(new BufferPool({device, BUFFER_POOL_BLOCK_SIZE * 1024 * usage_it.second, usage_it.first}), null));
            }

            var res_ins_it = _BufferPools.Add(usage_it.first, std::move(usage_buffer_pools));

            if (!res_ins_it.second)
            {
                throw new System.Exception("Failed to insert buffer pool");
            }
        }

        for (nint i = 0; i < thread_count; ++i)
        {
            _DescriptorPools.Add(std::make_unique<Dictionary<uint, DescriptorPool>>());
            _DescriptorSets.Add(std::make_unique<Dictionary<uint, DescriptorSet>>());
        }
    }

//    RenderFrame(@in RenderFrame) = delete;

//    RenderFrame(RenderFrame &&) = delete;

//    RenderFrame &operator =(@in RenderFrame) = delete;

//    RenderFrame &operator =(RenderFrame &&) = delete;

    public void Reset()
    {
        do
        {
            VkResult err = _FencePool.Wait();
            if (err != null)
            {
                (...) spdlog.error("[{}:{}] {}", ((char)__FILE__ + ROOT_PATH_SIZE), __LINE__, fmt.format(__VA_ARGS__));
                ("Detected Vulkan error: {}", GlobalMembers.ToString(err));
                abort();
            }
        } while (false);

        _FencePool.Reset();

        foreach (var command_pools_per_queue in _CommandPools)
        {
            foreach (var command_pool in command_pools_per_queue.second)
            {
                command_pool.reset_pool();
            }
        }

        foreach (var buffer_pools_per_usage in _BufferPools)
        {
            foreach (var buffer_pool in buffer_pools_per_usage.second)
            {
                buffer_pool.first.reset();
                buffer_pool.second = null;
            }
        }

        _SemaphorePool.Reset();
    }

    public Device GetDevice()
    {
        return _Device;
    }

    public FencePool GetFencePool()
    {
        return _FencePool;
    }

    public VkFence RequestFence()
    {
        return _FencePool.RequestFence();
    }

    public SemaphorePool GetSemaphorePool()
    {
        return _SemaphorePool;
    }

    public VkSemaphore RequestSemaphore()
    {
        return _SemaphorePool.RequestSemaphore();
    }

    public VkSemaphore RequestSemaphoreWithOwnership()
    {
        return _SemaphorePool.RequestSemaphoreWithOwnership();
    }

    public void ReleaseOwnedSemaphore(VkSemaphore semaphore)
    {
        _SemaphorePool.ReleaseOwnedSemaphore(semaphore);
    }

    /**
     * @brief Called when the swapchain changes
     * @param render_target A new render target with updated images
     */
    public void UpdateRenderTarget(std::unique_ptr<RenderTarget> &&render_target)
    {
        _SwapchainRenderTarget = std::move(render_target);
    }

    public RenderTarget GetRenderTarget()
    {
        return _SwapchainRenderTarget;
    }

    public RenderTarget GetRenderTargetConst()
    {
        return _SwapchainRenderTarget;
    }

    /**
     * @brief Requests a command buffer to the command pool of the active frame
     *        A frame should be active at the moment of requesting it
     * @param queue The queue command buffers will be submitted on
     * @param reset_mode Indicate how the command buffer will be used, may trigger a
     *        pool re-creation to set necessary flags
     * @param level Command buffer level, either primary or secondary
     * @param thread_index Selects the thread's command pool used to manage the buffer
     * @return A command buffer related to the current active frame
     */
    public CommandBuffer RequestCommandBuffer(in Queue queue, CommandBuffer.ResetMode reset_mode = CommandBuffer.ResetMode.ResetPool, VkCommandBufferLevel level = VK_COMMAND_BUFFER_LEVEL_PRIMARY, nint thread_index = 0)
    {
        Debug.Assert(thread_index < _ThreadCount && "Thread index is out of bounds");

        var command_pools = GetCommandPools(queue, reset_mode);

        var command_pool_it = std::find_if(command_pools.GetEnumerator(), command_pools.end(), (std::unique_ptr<CommandPool> cmd_pool) =>
        {
            return cmd_pool.get_thread_index() == thread_index;
        });

        return command_pool_it.request_command_buffer(level);
    }

    public DescriptorSet RequestDescriptorSet(DescriptorSetLayout descriptor_set_layout, BindingMap<VkDescriptorBufferInfo> buffer_infos, BindingMap<VkDescriptorImageInfo> image_infos, nint thread_index = 0)
    {
        Debug.Assert(thread_index < _ThreadCount && "Thread index is out of bounds");

        var descriptor_pool = GlobalMembers.RequestResource(_Device, null, *_DescriptorPools[thread_index], descriptor_set_layout);
        return request_resource(_Device, null, *_DescriptorSets[thread_index], descriptor_set_layout, descriptor_pool, buffer_infos, image_infos);
    }

    public void ClearDescriptors()
    {
        foreach (var desc_sets_per_thread in _DescriptorSets)
        {
            desc_sets_per_thread.clear();
        }

        foreach (var desc_pools_per_thread in _DescriptorPools)
        {
            foreach (var desc_pool in * desc_pools_per_thread)
            {
                desc_pool.second.reset();
            }
        }
    }

    /**
     * @brief Sets a new buffer allocation strategy
     * @param new_strategy The new buffer allocation strategy
     */
    public void SetBufferAllocationStrategy(BufferAllocationStrategy new_strategy)
    {
        _BufferAllocationStrategy = new_strategy;
    }

    /**
     * @param usage Usage of the buffer
     * @param size Amount of memory required
     * @param thread_index Index of the buffer pool to be used by the current thread
     * @return The requested allocation, it may be empty
     */
    public BufferAllocation AllocateBuffer(VkBufferUsageFlagBits usage, uint size, nint thread_index = 0)
    {
        Debug.Assert(thread_index < _ThreadCount && "Thread index is out of bounds");

        uint block_multiplier = SupportedUsageMap[usage];

        if (size > BUFFER_POOL_BLOCK_SIZE * 1024 * block_multiplier)
        {
            (...) spdlog.error("[{}:{}] {}", ((char)__FILE__ + ROOT_PATH_SIZE), __LINE__, fmt.format(__VA_ARGS__));
            ("Trying to allocate {} buffer of size {}KB which is larger than the buffer pool block size ({} KB)!", buffer_usage_to_string(usage), size / 1024, BUFFER_POOL_BLOCK_SIZE * block_multiplier);
            throw new System.Exception("Couldn't allocate render frame buffer.");
        }

        // Find a pool for this usage
        var buffer_pool_it = _BufferPools.find(usage);
        if (buffer_pool_it == _BufferPools.end())
        {
            (...) spdlog.error("[{}:{}] {}", ((char)__FILE__ + ROOT_PATH_SIZE), __LINE__, fmt.format(__VA_ARGS__));
            ("No buffer pool for buffer usage {}", usage);
            return BufferAllocation{};
        }

        var buffer_pool = buffer_pool_it.second.at(thread_index).first;
        var buffer_block = buffer_pool_it.second.at(thread_index).second;

        if (_BufferAllocationStrategy == BufferAllocationStrategy.OneAllocationPerBuffer || !buffer_block)
        {
            // If there is no block associated with the pool or we are creating a buffer for each allocation,
            // request a new buffer block
            buffer_block = &buffer_pool.request_buffer_block(GlobalMembers.ToU32(size));
        }

        var data = buffer_block.allocate(GlobalMembers.ToU32(size));

        // Check if the buffer block can allocate the requested size
        if (data.empty())
        {
            buffer_block = &buffer_pool.request_buffer_block(GlobalMembers.ToU32(size));

            data = buffer_block.allocate(GlobalMembers.ToU32(size));
        }

        return data;
    }

    /**
     * @brief Updates all the descriptor sets in the current frame at a specific thread index
     */
    public void UpdateDescriptorSets(nint thread_index = 0)
    {
        var thread_descriptor_sets = *_DescriptorSets[thread_index];
        foreach (var descriptor_set_it in thread_descriptor_sets)
        {
            descriptor_set_it.second.update();
        }
    }

    private Device _Device;

    /**
     * @brief Retrieve the frame's command pool(s)
     * @param queue The queue command buffers will be submitted on
     * @param reset_mode Indicate how the command buffers will be reset after execution,
     *        may trigger a pool re-creation to set necessary flags
     * @return The frame's command pool(s)
     */
    private Array<std::unique_ptr<CommandPool>> GetCommandPools(in Queue queue, CommandBuffer.ResetMode reset_mode)
    {
        var command_pool_it = _CommandPools.find(queue.get_family_index());

        if (command_pool_it != _CommandPools.end())
        {
            if (command_pool_it.second.at(0).get_reset_mode() != reset_mode)
            {
                _Device.WaitIdle();

                // Delete pools
                _CommandPools.Remove(command_pool_it);
            }
            else
            {
                return command_pool_it.second;
            }
        }

        Array<std::unique_ptr<CommandPool>> queue_command_pools = new Array<std::unique_ptr<CommandPool>>();
        for (nint i = 0; i < _ThreadCount; i++)
        {
            queue_command_pools.Add(std::make_unique<CommandPool>(_Device, queue.get_family_index(), this, i, reset_mode));
        }

        var res_ins_it = _CommandPools.Add(queue.get_family_index(), std::move(queue_command_pools));

        if (!res_ins_it.second)
        {
            throw new System.Exception("Failed to insert command pool");
        }

        command_pool_it = res_ins_it.first;

        return command_pool_it.second;
    }

    /// Commands pools associated to the frame
    private Dictionary<uint, Array<std::unique_ptr<CommandPool>>> _CommandPools = new Dictionary<uint, Array<std::unique_ptr<CommandPool>>>();

    /// Descriptor pools for the frame
    private Array<std::unique_ptr<Dictionary<uint, DescriptorPool>>> _DescriptorPools = new Array<std::unique_ptr<Dictionary<uint, DescriptorPool>>>();

    /// Descriptor sets for the frame
    private Array<std::unique_ptr<Dictionary<uint, DescriptorSet>>> _DescriptorSets = new Array<std::unique_ptr<Dictionary<uint, DescriptorSet>>>();

    private FencePool _FencePool = new FencePool();

    private SemaphorePool _SemaphorePool = new SemaphorePool();

    private nint _ThreadCount = new nint();

    private std::unique_ptr<RenderTarget> _SwapchainRenderTarget = new std::unique_ptr<RenderTarget>();

    private BufferAllocationStrategy _BufferAllocationStrategy = BufferAllocationStrategy.MultipleAllocationsPerBuffer;

    private Dictionary<VkBufferUsageFlagBits, Array<Tuple<BufferPool, BufferBlock >>> _BufferPools = new Dictionary<VkBufferUsageFlagBits, Array<Tuple<BufferPool, BufferBlock >>>();
}
} // namespace vkb





