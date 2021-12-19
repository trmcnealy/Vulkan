namespace Vulkan.MemoryAllocator;

/// <summary>
/// Flags to be passed as VmaAllocationCreateInfo::flags.
/// </summary>
public enum VmaAllocationCreateFlagBits : uint
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Set this flag if the allocation should have its own memory block.Use it for special, big resources, like fullscreen images used as attachments.You should not use this flag if VmaAllocationCreateInfo::pool is not null.
    /// </remarks>
    VMA_ALLOCATION_CREATE_DEDICATED_MEMORY_BIT = 0x00000001,
        
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Set this flag to only try to allocate from existing `VkDeviceMemory` blocks and never create new such block.If new allocation cannot be placed in any of the existing blocks, allocation
    /// fails with `VK_ERROR_OUT_OF_DEVICE_MEMORY` error.You should not use #VMA_ALLOCATION_CREATE_DEDICATED_MEMORY_BIT and
    /// #VMA_ALLOCATION_CREATE_NEVER_ALLOCATE_BIT at the same time. It makes no sense.If VmaAllocationCreateInfo::pool is not null, this flag is implied and ignored.
    /// </remarks>
    VMA_ALLOCATION_CREATE_NEVER_ALLOCATE_BIT = 0x00000002,
        
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Set this flag to use a memory that will be persistently mapped and retrieve pointer to it.Pointer to mapped memory will be returned through VmaAllocationInfo::pMappedData.It is valid to use this flag for allocation made from memory type that is not
    /// `HOST_VISIBLE`. This flag is then ignored and memory is not mapped. This is
    /// useful if you need an allocation that is efficient to use on GPU
    /// (`DEVICE_LOCAL`) and still want to map it directly if possible on platforms that
    /// support it (e.g. Intel GPU).You should not use this flag together with #VMA_ALLOCATION_CREATE_CAN_BECOME_LOST_BIT.
    /// </remarks>
    VMA_ALLOCATION_CREATE_MAPPED_BIT = 0x00000004,
        
    /// <summary>
    /// Allocation created with this flag can become lost as a result of another
    /// allocation with #VMA_ALLOCATION_CREATE_CAN_MAKE_OTHER_LOST_BIT flag, so you
    /// must check it before use.
    /// </summary>
    /// <remarks>
    /// To check if allocation is not lost, call vmaGetAllocationInfo() and check if
    /// VmaAllocationInfo::deviceMemory is not `VK_NULL_HANDLE`.For details about supporting lost allocations, see Lost Allocations
    /// chapter of User Guide on Main Page.You should not use this flag together with #VMA_ALLOCATION_CREATE_MAPPED_BIT.
    /// </remarks>
    VMA_ALLOCATION_CREATE_CAN_BECOME_LOST_BIT = 0x00000008,
        
    /// <summary>
    /// While creating allocation using this flag, other allocations that were
    /// created with flag #VMA_ALLOCATION_CREATE_CAN_BECOME_LOST_BIT can become lost.
    /// </summary>
    /// <remarks>
    /// For details about supporting lost allocations, see Lost Allocations
    /// chapter of User Guide on Main Page.
    /// </remarks>
    VMA_ALLOCATION_CREATE_CAN_MAKE_OTHER_LOST_BIT = 0x00000010,
        
    /// <summary>
    /// Set this flag to treat VmaAllocationCreateInfo::pUserData as pointer to a
    /// null-terminated string. Instead of copying pointer value, a local copy of the
    /// string is made and stored in allocation's `pUserData`. The string is automatically
    /// freed together with the allocation. It is also used in vmaBuildStatsString().
    /// </summary>
    VMA_ALLOCATION_CREATE_USER_DATA_COPY_STRING_BIT = 0x00000020,
        
    /// <summary>
    /// Allocation will be created from upper stack in a double stack pool.
    /// </summary>
    /// <remarks>
    /// This flag is only allowed for custom pools created with #VMA_POOL_CREATE_LINEAR_ALGORITHM_BIT flag.
    /// </remarks>
    VMA_ALLOCATION_CREATE_UPPER_ADDRESS_BIT = 0x00000040,
        
    /// <summary>
    /// Create both buffer/image and allocation, but don't bind them together.
    /// It is useful when you want to bind yourself to do some more advanced binding, e.g. using some extensions.
    /// The flag is meaningful only with functions that bind by default: vmaCreateBuffer(), vmaCreateImage().
    /// Otherwise it is ignored.
    /// </summary>
    VMA_ALLOCATION_CREATE_DONT_BIND_BIT = 0x00000080,
        
    /// <summary>
    /// Create allocation only if additional device memory required for it, if any, won't exceed
    /// memory budget. Otherwise return `VK_ERROR_OUT_OF_DEVICE_MEMORY`.
    /// </summary>
    VMA_ALLOCATION_CREATE_WITHIN_BUDGET_BIT = 0x00000100,
        
    /// <summary>
    /// Allocation strategy that chooses smallest possible free range for the
    /// allocation.
    /// </summary>
    VMA_ALLOCATION_CREATE_STRATEGY_BEST_FIT_BIT = 0x00010000,
        
    /// <summary>
    /// Allocation strategy that chooses biggest possible free range for the
    /// allocation.
    /// </summary>
    VMA_ALLOCATION_CREATE_STRATEGY_WORST_FIT_BIT = 0x00020000,
        
    /// <summary>
    /// Allocation strategy that chooses first suitable free range for the
    /// allocation.
    /// </summary>
    /// <remarks>
    /// "First" doesn't necessarily means the one with smallest offset in memory,
    /// but rather the one that is easiest and fastest to find.
    /// </remarks>
    VMA_ALLOCATION_CREATE_STRATEGY_FIRST_FIT_BIT = 0x00040000,
        
    /// <summary>
    /// Allocation strategy that tries to minimize memory usage.
    /// </summary>
    VMA_ALLOCATION_CREATE_STRATEGY_MIN_MEMORY_BIT = VMA_ALLOCATION_CREATE_STRATEGY_BEST_FIT_BIT,
        
    /// <summary>
    /// Allocation strategy that tries to minimize allocation time.
    /// </summary>
    VMA_ALLOCATION_CREATE_STRATEGY_MIN_TIME_BIT = VMA_ALLOCATION_CREATE_STRATEGY_FIRST_FIT_BIT,
        
    /// <summary>
    /// Allocation strategy that tries to minimize memory fragmentation.
    /// </summary>
    VMA_ALLOCATION_CREATE_STRATEGY_MIN_FRAGMENTATION_BIT = VMA_ALLOCATION_CREATE_STRATEGY_WORST_FIT_BIT,
        
    /// <summary>
    /// A bit mask to extract only `STRATEGY` bits from entire set of flags.
    /// </summary>
    VMA_ALLOCATION_CREATE_STRATEGY_MASK = VMA_ALLOCATION_CREATE_STRATEGY_BEST_FIT_BIT |VMA_ALLOCATION_CREATE_STRATEGY_WORST_FIT_BIT |VMA_ALLOCATION_CREATE_STRATEGY_FIRST_FIT_BIT,
        
    /// <summary>
    /// A bit mask to extract only `STRATEGY` bits from entire set of flags.
    /// </summary>
    VMA_ALLOCATION_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}