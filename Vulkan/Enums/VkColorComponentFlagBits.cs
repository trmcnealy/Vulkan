using System;

namespace Vulkan
{
    [Flags]
    public enum VkColorComponentFlagBits : uint
    {
        R           = 0x00000001,
        G           = 0x00000002,
        B           = 0x00000004,
        A           = 0x00000008,
        MaxEnumFlag = 0x7FFFFFFF
    }
}
