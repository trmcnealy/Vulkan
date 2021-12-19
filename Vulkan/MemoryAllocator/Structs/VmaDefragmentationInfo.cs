using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

/// <summary>
/// 
/// </summary>
/// <remarks>
/// @brief Deprecated. Optional configuration parameters to be passed to function vmaDefragment().@deprecated This is a part of the old interface. It is recommended to use structure #VmaDefragmentationInfo2 and function vmaDefragmentationBegin() instead.
/// </remarks>
[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public partial struct VmaDefragmentationInfo
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Maximum total numbers of bytes that can be copied while moving allocations to different places.Default is `VK_WHOLE_SIZE`, which means no limit.
    /// </remarks>
    public ulong maxBytesToMove;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Maximum number of allocations that can be moved to different place.Default is `UINT32_MAX`, which means no limit.
    /// </remarks>
    public uint maxAllocationsToMove;
}