namespace Vulkan.MemoryAllocator;

/// <summary>
/// Flags to be used in VmaRecordSettings::flags.
/// </summary>
public enum VmaRecordFlagBits : uint
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Enables flush after recording every function call.Enable it if you expect your application to crash, which may leave recording file truncated.
    /// It may degrade performance though.
    /// </remarks>
    VMA_RECORD_FLUSH_AFTER_CALL_BIT = 0x00000001,
        
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Enables flush after recording every function call.Enable it if you expect your application to crash, which may leave recording file truncated.
    /// It may degrade performance though.
    /// </remarks>
    VMA_RECORD_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}