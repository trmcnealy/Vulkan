using System;
using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

/// <summary>
/// Parameters of an existing virtual allocation, returned by vmaGetVirtualAllocationInfo().
/// </summary>
[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public partial struct VmaVirtualAllocationInfo
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Size of the allocation.Same value as passed in VmaVirtualAllocationCreateInfo::size.
    /// </remarks>
    public ulong size;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Custom pointer associated with the allocation.Same value as passed in VmaVirtualAllocationCreateInfo::pUserData or to vmaSetVirtualAllocationUserData().
    /// </remarks>
    public nint pUserData;
}