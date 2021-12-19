using System;

namespace Vulkan
{
    [Flags]
    public enum VkDisplayPlaneAlphaFlagBitsKHR : uint
    {
        Opaque                = 0x00000001,
        Global                = 0x00000002,
        PerPixel              = 0x00000004,
        PerPixelPremultiplied = 0x00000008,
        MaxEnumFlag           = 0x7FFFFFFF
    }
}
