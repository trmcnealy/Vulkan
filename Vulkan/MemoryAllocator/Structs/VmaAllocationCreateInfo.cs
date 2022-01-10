using System;
using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public partial struct VmaAllocationCreateInfo
{
    /// <summary>
    /// Use #VmaAllocationCreateFlagBits enum.
    /// </summary>
    public uint flags;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Intended usage of memory.You can leave #VMA_MEMORY_USAGE_UNKNOWN if you specify memory requirements in other way. @n If `pool` is not null, this member is ignored.
    /// </remarks>
    public VmaMemoryUsage usage;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Flags that must be set in a Memory Type chosen for an allocation.Leave 0 if you specify memory requirements in other way. @n If `pool` is not null, this member is ignored.
    /// </remarks>
    public uint requiredFlags;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Flags that preferably should be set in a memory type chosen for an allocation.Set to 0 if no additional flags are preferred. @n If `pool` is not null, this member is ignored.
    /// </remarks>
    public uint preferredFlags;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Bitmask containing one bit set for every memory type acceptable for this allocation.Value 0 is equivalent to `UINT32_MAX` - it means any memory type is accepted if
    /// it meets other requirements specified by this structure, with no further
    /// restrictions on memory type index. @n If `pool` is not null, this member is ignored.
    /// </remarks>
    public uint memoryTypeBits;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Pool that this allocation should be created in.Leave `0` to allocate from default pool. If not null, members:
    /// `usage`, `requiredFlags`, `preferredFlags`, `memoryTypeBits` are ignored.
    /// </remarks>
    public VmaPool pool;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Custom general-purpose pointer that will be stored in #VmaAllocation, can be read as VmaAllocationInfo::pUserData and changed using vmaSetAllocationUserData().If #VMA_ALLOCATION_CREATE_USER_DATA_COPY_STRING_BIT is used, it must be either
    /// null or pointer to a null-terminated string. The string will be then copied to
    /// internal buffer, so it doesn't need to be valid after allocation call.
    /// </remarks>
    public nint pUserData;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief A floating-point value between 0 and 1, indicating the priority of the allocation relative to other memory allocations.It is used only when #VMA_ALLOCATOR_CREATE_EXT_MEMORY_PRIORITY_BIT flag was used during creation of the #VmaAllocator object
    /// and this allocation ends up as dedicated or is explicitly forced as dedicated using #VMA_ALLOCATION_CREATE_DEDICATED_MEMORY_BIT.
    /// Otherwise, it has the priority of a memory block where it is placed and this variable is ignored.
    /// </remarks>
    public float priority;
}