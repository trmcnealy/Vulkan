namespace Vulkan.MemoryAllocator;

/// <summary>
/// Flags to be passed as VmaVirtualAllocationCreateInfo::flags.
/// </summary>
public enum VmaVirtualAllocationCreateFlagBits : uint
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Allocation will be created from upper stack in a double stack pool.This flag is only allowed for virtual blocks created with #VMA_VIRTUAL_BLOCK_CREATE_LINEAR_ALGORITHM_BIT flag.
    /// </remarks>
    VMA_VIRTUAL_ALLOCATION_CREATE_UPPER_ADDRESS_BIT = VmaAllocationCreateFlagBits.VMA_ALLOCATION_CREATE_UPPER_ADDRESS_BIT,
        
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Allocation strategy that tries to minimize memory usage.
    /// </remarks>
    VMA_VIRTUAL_ALLOCATION_CREATE_STRATEGY_MIN_MEMORY_BIT = VmaAllocationCreateFlagBits.VMA_ALLOCATION_CREATE_STRATEGY_MIN_MEMORY_BIT,
        
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Allocation strategy that tries to minimize allocation time.
    /// </remarks>
    VMA_VIRTUAL_ALLOCATION_CREATE_STRATEGY_MIN_TIME_BIT = VmaAllocationCreateFlagBits.VMA_ALLOCATION_CREATE_STRATEGY_MIN_TIME_BIT,
        
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Allocation strategy that tries to minimize memory fragmentation.
    /// </remarks>
    VMA_VIRTUAL_ALLOCATION_CREATE_STRATEGY_MIN_FRAGMENTATION_BIT = VmaAllocationCreateFlagBits.VMA_ALLOCATION_CREATE_STRATEGY_MIN_FRAGMENTATION_BIT,
        
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief A bit mask to extract only `STRATEGY` bits from entire set of flags.These stategy flags are binary compatible with equivalent flags in #VmaAllocationCreateFlagBits.
    /// </remarks>
    VMA_VIRTUAL_ALLOCATION_CREATE_STRATEGY_MASK = VmaAllocationCreateFlagBits.VMA_ALLOCATION_CREATE_STRATEGY_MASK,
        
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief A bit mask to extract only `STRATEGY` bits from entire set of flags.These stategy flags are binary compatible with equivalent flags in #VmaAllocationCreateFlagBits.
    /// </remarks>
    VMA_VIRTUAL_ALLOCATION_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}