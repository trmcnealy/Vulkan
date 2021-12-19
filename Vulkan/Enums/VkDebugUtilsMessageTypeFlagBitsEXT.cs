using System;

namespace Vulkan
{
    [Flags]
    public enum VkDebugUtilsMessageTypeFlagBitsEXT : uint
    {
        General     = 0x00000001,
        Validation  = 0x00000002,
        Performance = 0x00000004,
        MaxEnumFlag = 0x7FFFFFFF
    }
}
