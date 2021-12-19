using System;
using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

/// <summary>
/// 
/// </summary>
/// <remarks>
/// @brief Describes parameter of created #VmaPool.
/// </remarks>
[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public partial struct VmaPoolCreateInfo
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Vulkan memory type index to allocate this pool from.
    /// </remarks>
    public uint memoryTypeIndex;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Use combination of #VmaPoolCreateFlagBits.
    /// </remarks>
    public uint flags;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Size of a single `VkDeviceMemory` block to be allocated as part of this pool, in bytes. Optional.Specify nonzero to set explicit, constant size of memory blocks used by this
    /// pool.Leave 0 to use default and let the library manage block sizes automatically.
    /// Sizes of particular blocks may vary.
    /// </remarks>
    public ulong blockSize;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Minimum number of blocks to be always allocated in this pool, even if they stay empty.Set to 0 to have no preallocated blocks and allow the pool be completely empty.
    /// </remarks>
    public ulong minBlockCount;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Maximum number of blocks that can be allocated in this pool. Optional.Set to 0 to use default, which is `SIZE_MAX`, which means no limit.Set to same value as VmaPoolCreateInfo::minBlockCount to have fixed amount of memory allocated
    /// throughout whole lifetime of this pool.
    /// </remarks>
    public ulong maxBlockCount;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Maximum number of additional frames that are in use at the same time as current frame.This value is used only when you make allocations with
    /// #VMA_ALLOCATION_CREATE_CAN_BECOME_LOST_BIT flag. Such allocation cannot become
    /// lost if allocation.lastUseFrameIndex &gt;= allocator.currentFrameIndex - frameInUseCount.For example, if you double-buffer your command buffers, so resources used for
    /// rendering in previous frame may still be in use by the GPU at the moment you
    /// allocate resources needed for the current frame, set this value to 1.If you want to allow any allocations other than used in the current frame to
    /// become lost, set this value to 0.
    /// </remarks>
    public uint frameInUseCount;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief A floating-point value between 0 and 1, indicating the priority of the allocations in this pool relative to other memory allocations.It is used only when #VMA_ALLOCATOR_CREATE_EXT_MEMORY_PRIORITY_BIT flag was used during creation of the #VmaAllocator object.
    /// Otherwise, this variable is ignored.
    /// </remarks>
    public float priority;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Additional minimum alignment to be used for all allocations created from this pool. Can be 0.Leave 0 (default) not to impose any additional alignment. If not 0, it must be a power of two.
    /// It can be useful in cases where alignment returned by Vulkan by functions like `vkGetBufferMemoryRequirements` is not enough,
    /// e.g. when doing interop with OpenGL.
    /// </remarks>
    public ulong minAllocationAlignment;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Additional `pNext` chain to be attached to `VkMemoryAllocateInfo` used for every allocation made by this pool. Optional.Optional, can be null. If not null, it must point to a `pNext` chain of structures that can be attached to `VkMemoryAllocateInfo`.
    /// It can be useful for special needs such as adding `VkExportMemoryAllocateInfoKHR`.
    /// Structures pointed by this member must remain alive and unchanged for the whole lifetime of the custom pool.Please note that some structures, e.g. `VkMemoryPriorityAllocateInfoEXT`, `VkMemoryDedicatedAllocateInfoKHR`,
    /// can be attached automatically by this library when using other, more convenient of its features.
    /// </remarks>
    public nint pMemoryAllocateNext;
}