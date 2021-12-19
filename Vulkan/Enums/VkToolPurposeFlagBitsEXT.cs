using System;

namespace Vulkan
{
    [Flags]
    public enum VkToolPurposeFlagBitsEXT : uint
    {
        Validation         = 0x00000001,
        Profiling          = 0x00000002,
        Tracing            = 0x00000004,
        AdditionalFeatures = 0x00000008,
        ModifyingFeatures  = 0x00000010,
        DebugReporting     = 0x00000020,
        DebugMarkers       = 0x00000040,
        MaxEnumFlag        = 0x7FFFFFFF
    }
}
