using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

/// <summary>
/// 
/// </summary>
/// <remarks>
/// @brief Describes parameter of existing #VmaPool.
/// </remarks>
[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public partial struct VmaPoolStats
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Total amount of `VkDeviceMemory` allocated from Vulkan for this pool, in bytes.
    /// </remarks>
    public ulong size;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Total number of bytes in the pool not used by any #VmaAllocation.
    /// </remarks>
    public ulong unusedSize;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Number of #VmaAllocation objects created from this pool that were not destroyed or lost.
    /// </remarks>
    public ulong allocationCount;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Number of continuous memory ranges in the pool not used by any #VmaAllocation.
    /// </remarks>
    public ulong unusedRangeCount;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Size of the largest continuous free memory region available for new allocation.Making a new allocation of that size is not guaranteed to succeed because of
    /// possible additional margin required to respect alignment and buffer/image
    /// granularity.
    /// </remarks>
    public ulong unusedRangeSizeMax;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Number of `VkDeviceMemory` blocks allocated for this pool.
    /// </remarks>
    public ulong blockCount;
}