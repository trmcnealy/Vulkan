using System;

namespace Vulkan
{
    [Flags]
    public enum VkCullModeFlagBits : uint
    {
        None         = 0,
        Front        = 0x00000001,
        Back         = 0x00000002,
        FrontAndBack = 0x00000003,
        MaxEnumFlag  = 0x7FFFFFFF
    }
}
