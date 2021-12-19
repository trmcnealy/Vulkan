using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

/// <summary>
/// 
/// </summary>
/// <remarks>
/// @brief Statistics returned by function vmaDefragment().
/// </remarks>
[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public partial struct VmaDefragmentationStats
{
    /// <summary>
    /// Total number of bytes that have been copied while moving allocations to different places.
    /// </summary>
    public ulong bytesMoved;

    /// <summary>
    /// Total number of bytes that have been released to the system by freeing empty `VkDeviceMemory` objects.
    /// </summary>
    public ulong bytesFreed;

    /// <summary>
    /// Number of allocations that have been moved to different places.
    /// </summary>
    public uint allocationsMoved;

    /// <summary>
    /// Number of empty `VkDeviceMemory` objects that have been released to the system.
    /// </summary>
    public uint deviceMemoryBlocksFreed;
}