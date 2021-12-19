using System;

namespace Vulkan
{
    [Flags]
    public enum VkSampleCountFlagBits : uint
    {
        One         = 0x00000001,
        Two         = 0x00000002,
        Four        = 0x00000004,
        Eight       = 0x00000008,
        Sixteen     = 0x00000010,
        Thritytwo   = 0x00000020,
        Sixtyfour   = 0x00000040,
        MaxEnumFlag = 0x7FFFFFFF
    }
}
