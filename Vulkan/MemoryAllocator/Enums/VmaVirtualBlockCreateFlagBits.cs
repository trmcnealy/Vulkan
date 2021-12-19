namespace Vulkan.MemoryAllocator;

/// <summary>
/// Flags to be passed as VmaVirtualBlockCreateInfo::flags.
/// </summary>
public enum VmaVirtualBlockCreateFlagBits : uint
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Enables alternative, linear allocation algorithm in this virtual block.Specify this flag to enable linear allocation algorithm, which always creates
    /// new allocations after last one and doesn't reuse space from allocations freed in
    /// between. It trades memory consumption for simplified algorithm and data
    /// structure, which has better performance and uses less memory for metadata.By using this flag, you can achieve behavior of free-at-once, stack,
    /// ring buffer, and double stack.
    /// For details, see documentation chapter @ref linear_algorithm.
    /// </remarks>
    VMA_VIRTUAL_BLOCK_CREATE_LINEAR_ALGORITHM_BIT = 0x00000001,
        
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Enables alternative, buddy allocation algorithm in this virtual block.It operates on a tree of blocks, each having size that is a power of two and
    /// a half of its parent's size. Comparing to default algorithm, this one provides
    /// faster allocation and deallocation and decreased external fragmentation,
    /// at the expense of more memory wasted (internal fragmentation).
    /// For details, see documentation chapter @ref buddy_algorithm.
    /// </remarks>
    VMA_VIRTUAL_BLOCK_CREATE_BUDDY_ALGORITHM_BIT = 0x00000002,
        
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Bit mask to extract only `ALGORITHM` bits from entire set of flags.
    /// </remarks>
    VMA_VIRTUAL_BLOCK_CREATE_ALGORITHM_MASK = VMA_VIRTUAL_BLOCK_CREATE_LINEAR_ALGORITHM_BIT |VMA_VIRTUAL_BLOCK_CREATE_BUDDY_ALGORITHM_BIT,
        
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Bit mask to extract only `ALGORITHM` bits from entire set of flags.
    /// </remarks>
    VMA_VIRTUAL_BLOCK_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}