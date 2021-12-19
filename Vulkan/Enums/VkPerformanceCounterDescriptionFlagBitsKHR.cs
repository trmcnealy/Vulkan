using System;

namespace Vulkan
{
    [Flags]
    public enum VkPerformanceCounterDescriptionFlagBitsKHR : uint
    {
        PerformanceImpacting = 0x00000001,
        ConcurrentlyImpacted = 0x00000002,
        MaxEnumFlag          = 0x7FFFFFFF
    }
}
