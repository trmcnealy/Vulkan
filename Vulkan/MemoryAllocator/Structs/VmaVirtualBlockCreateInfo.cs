using System;
using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

/// <summary>
/// Parameters of created #VmaVirtualBlock object to be passed to vmaCreateVirtualBlock().
/// </summary>
[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public partial struct VmaVirtualBlockCreateInfo
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Total size of the virtual block.Sizes can be expressed in bytes or any units you want as long as you are consistent in using them.
    /// For example, if you allocate from some array of structures, 1 can mean single instance of entire structure.
    /// </remarks>
    public ulong size;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Use combination of #VmaVirtualBlockCreateFlagBits.
    /// </remarks>
    public VmaVirtualBlockCreateFlagBits flags;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Custom CPU memory allocation callbacks. Optional.Optional, can be null. When specified, they will be used for all CPU-side memory allocations.
    /// </remarks>
    public nint pAllocationCallbacks;
}