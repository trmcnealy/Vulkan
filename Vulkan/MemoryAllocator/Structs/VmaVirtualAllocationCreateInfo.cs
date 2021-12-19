using System;
using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

/// <summary>
/// Parameters of created virtual allocation to be passed to vmaVirtualAllocate().
/// </summary>
[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public partial struct VmaVirtualAllocationCreateInfo
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Size of the allocation.Cannot be zero.
    /// </remarks>
    public ulong size;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Required alignment of the allocation. Optional.Must be power of two. Special value 0 has the same meaning as 1 - means no special alignment is required, so allocation can start at any offset.
    /// </remarks>
    public ulong alignment;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Use combination of #VmaVirtualAllocationCreateFlagBits.
    /// </remarks>
    public uint flags;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Custom pointer to be associated with the allocation. Optional.It can be any value and can be used for user-defined purposes. It can be fetched or changed later.
    /// </remarks>
    public nint pUserData;
}