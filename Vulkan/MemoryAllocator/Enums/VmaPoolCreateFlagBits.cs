namespace Vulkan.MemoryAllocator;

/// <summary>
/// Flags to be passed as VmaPoolCreateInfo::flags.
/// </summary>
public enum VmaPoolCreateFlagBits : uint
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Use this flag if you always allocate only buffers and linear images or only optimal images out of this pool and so Buffer-Image Granularity can be ignored.This is an optional optimization flag.If you always allocate using vmaCreateBuffer(), vmaCreateImage(),
    /// vmaAllocateMemoryForBuffer(), then you don't need to use it because allocator
    /// knows exact type of your allocations so it can handle Buffer-Image Granularity
    /// in the optimal way.If you also allocate using vmaAllocateMemoryForImage() or vmaAllocateMemory(),
    /// exact type of such allocations is not known, so allocator must be conservative
    /// in handling Buffer-Image Granularity, which can lead to suboptimal allocation
    /// (wasted memory). In that case, if you can make sure you always allocate only
    /// buffers and linear images or only optimal images out of this pool, use this flag
    /// to make allocator disregard Buffer-Image Granularity and so make allocations
    /// faster and more optimal.
    /// </remarks>
    VMA_POOL_CREATE_IGNORE_BUFFER_IMAGE_GRANULARITY_BIT = 0x00000002,
        
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Enables alternative, linear allocation algorithm in this pool.Specify this flag to enable linear allocation algorithm, which always creates
    /// new allocations after last one and doesn't reuse space from allocations freed in
    /// between. It trades memory consumption for simplified algorithm and data
    /// structure, which has better performance and uses less memory for metadata.By using this flag, you can achieve behavior of free-at-once, stack,
    /// ring buffer, and double stack.
    /// For details, see documentation chapter @ref linear_algorithm.When using this flag, you must specify VmaPoolCreateInfo::maxBlockCount == 1 (or 0 for default).
    /// </remarks>
    VMA_POOL_CREATE_LINEAR_ALGORITHM_BIT = 0x00000004,
        
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Enables alternative, buddy allocation algorithm in this pool.It operates on a tree of blocks, each having size that is a power of two and
    /// a half of its parent's size. Comparing to default algorithm, this one provides
    /// faster allocation and deallocation and decreased external fragmentation,
    /// at the expense of more memory wasted (internal fragmentation).
    /// For details, see documentation chapter @ref buddy_algorithm.
    /// </remarks>
    VMA_POOL_CREATE_BUDDY_ALGORITHM_BIT = 0x00000008,
        
    /// <summary>
    /// Bit mask to extract only `ALGORITHM` bits from entire set of flags.
    /// </summary>
    VMA_POOL_CREATE_ALGORITHM_MASK = VMA_POOL_CREATE_LINEAR_ALGORITHM_BIT |VMA_POOL_CREATE_BUDDY_ALGORITHM_BIT,
        
    /// <summary>
    /// Bit mask to extract only `ALGORITHM` bits from entire set of flags.
    /// </summary>
    VMA_POOL_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}