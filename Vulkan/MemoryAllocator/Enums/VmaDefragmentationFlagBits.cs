namespace Vulkan.MemoryAllocator;

/// <summary>
/// Flags to be used in vmaDefragmentationBegin(). None at the moment. Reserved for future use.
/// </summary>
public enum VmaDefragmentationFlagBits : uint
{
    VMA_DEFRAGMENTATION_FLAG_INCREMENTAL = 0x1,
        
    VMA_DEFRAGMENTATION_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}