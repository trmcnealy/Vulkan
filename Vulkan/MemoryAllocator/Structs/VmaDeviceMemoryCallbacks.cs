using System;
using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

/// <summary>
/// 
/// </summary>
/// <remarks>
/// @brief Set of callbacks that the library will call for `vkAllocateMemory` and `vkFreeMemory`.Provided for informative purpose, e.g. to gather statistics about number of
/// allocations or total amount of memory allocated in Vulkan.Used in VmaAllocatorCreateInfo::pDeviceMemoryCallbacks.
/// </remarks>
[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public partial struct VmaDeviceMemoryCallbacks
{
    /// <summary>
    /// Optional, can be null.
    /// </summary>
    public PFN_vmaAllocateDeviceMemoryFunction pfnAllocate;

    /// <summary>
    /// Optional, can be null.
    /// </summary>
    public PFN_vmaFreeDeviceMemoryFunction pfnFree;

    /// <summary>
    /// Optional, can be null.
    /// </summary>
    public nint pUserData;
}