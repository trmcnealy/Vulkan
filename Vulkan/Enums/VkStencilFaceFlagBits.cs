using System;

namespace Vulkan
{
    [Flags]
    public enum VkStencilFaceFlagBits : uint
    {
        Front        = 0x00000001,
        Back         = 0x00000002,
        FrontAndBack = 0x00000003,
        MaxEnumFlag  = 0x7FFFFFFF
    }
}
