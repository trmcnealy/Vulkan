using System;

namespace Vulkan
{
    [Flags]
    public enum VkQueryControlFlagBits : uint
    {
        Precise     = 0x00000001,
        MaxEnumFlag = 0x7FFFFFFF
    }
}
