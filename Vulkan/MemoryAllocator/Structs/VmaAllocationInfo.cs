using System;
using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

/// <summary>
/// 
/// </summary>
/// <remarks>
/// @brief Parameters of #VmaAllocation objects, that can be retrieved using function vmaGetAllocationInfo().
/// </remarks>
[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public partial struct VmaAllocationInfo
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Memory type index that this allocation was allocated from.It never changes.
    /// </remarks>
    public uint memoryType;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Handle to Vulkan memory object.Same memory object can be shared by multiple allocations.It can change after call to vmaDefragment() if this allocation is passed to the function, or if allocation is lost.If the allocation is lost, it is equal to `VK_NULL_HANDLE`.
    /// </remarks>
    public VkDeviceMemory deviceMemory;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Offset in `VkDeviceMemory` object to the beginning of this allocation, in bytes. `(deviceMemory, offset)` pair is unique to this allocation.You usually don't need to use this offset. If you create a buffer or an image together with the allocation using e.g. function
    /// vmaCreateBuffer(), vmaCreateImage(), functions that operate on these resources refer to the beginning of the buffer or image,
    /// not entire device memory block. Functions like vmaMapMemory(), vmaBindBufferMemory() also refer to the beginning of the allocation
    /// and apply this offset automatically.It can change after call to vmaDefragment() if this allocation is passed to the function, or if allocation is lost.
    /// </remarks>
    public ulong offset;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Size of this allocation, in bytes.It never changes, unless allocation is lost.@note Allocation size returned in this variable may be greater than the size
    /// requested for the resource e.g. as `VkBufferCreateInfo::size`. Whole size of the
    /// allocation is accessible for operations on memory e.g. using a pointer after
    /// mapping with vmaMapMemory(), but operations on the resource e.g. using
    /// `vkCmdCopyBuffer` must be limited to the size of the resource.
    /// </remarks>
    public ulong size;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Pointer to the beginning of this allocation as mapped data.If the allocation hasn't been mapped using vmaMapMemory() and hasn't been
    /// created with #VMA_ALLOCATION_CREATE_MAPPED_BIT flag, this value is null.It can change after call to vmaMapMemory(), vmaUnmapMemory().
    /// It can also change after call to vmaDefragment() if this allocation is passed to the function.
    /// </remarks>
    public nint pMappedData;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Custom general-purpose pointer that was passed as VmaAllocationCreateInfo::pUserData or set using vmaSetAllocationUserData().It can change after call to vmaSetAllocationUserData() for this allocation.
    /// </remarks>
    public nint pUserData;
}