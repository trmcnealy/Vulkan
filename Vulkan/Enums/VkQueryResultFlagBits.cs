using System;

namespace Vulkan
{
    [Flags]
    public enum VkQueryResultFlagBits : uint
    {
        Sixtyfour        = 0x00000001,
        Wait             = 0x00000002,
        WithAvailability = 0x00000004,
        Partial          = 0x00000008,
        MaxEnumFlag      = 0x7FFFFFFF
    }
}
