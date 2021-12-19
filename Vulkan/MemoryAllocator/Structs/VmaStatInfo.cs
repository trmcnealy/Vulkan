using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

/// <summary>
/// 
/// </summary>
/// <remarks>
/// @brief Calculated statistics of memory usage in entire allocator.
/// </remarks>
[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public partial struct VmaStatInfo
{
    /// <summary>
    /// Number of `VkDeviceMemory` Vulkan memory blocks allocated.
    /// </summary>
    public uint blockCount;

    /// <summary>
    /// Number of #VmaAllocation allocation objects allocated.
    /// </summary>
    public uint allocationCount;

    /// <summary>
    /// Number of free ranges of memory between allocations.
    /// </summary>
    public uint unusedRangeCount;

    /// <summary>
    /// Total number of bytes occupied by all allocations.
    /// </summary>
    public ulong usedBytes;

    /// <summary>
    /// Total number of bytes occupied by unused ranges.
    /// </summary>
    public ulong unusedBytes;

    public ulong allocationSizeMin;

    public ulong allocationSizeAvg;

    public ulong allocationSizeMax;

    public ulong unusedRangeSizeMin;

    public ulong unusedRangeSizeAvg;

    public ulong unusedRangeSizeMax;
}