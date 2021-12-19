using System;

namespace Vulkan
{
    [Flags]
    public enum VkCompositeAlphaFlagBitsKHR : uint
    {
        Opaque         = 0x00000001,
        PreMultiplied  = 0x00000002,
        PostMultiplied = 0x00000004,
        Inherit        = 0x00000008,
        MaxEnumFlag    = 0x7FFFFFFF
    }
}
