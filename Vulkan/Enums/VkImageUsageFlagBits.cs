using System;

namespace Vulkan
{
    [Flags]
    public enum VkImageUsageFlagBits: uint
    {
        TransferSrc                   = 0x00000001,
        TransferDst                   = 0x00000002,
        Sampled                       = 0x00000004,
        Storage                       = 0x00000008,
        ColorAttachment               = 0x00000010,
        DepthStencilAttachment        = 0x00000020,
        TransientAttachment           = 0x00000040,
        InputAttachment               = 0x00000080,
        FragmentDensityMap            = 0x00000200,
        FragmentShadingRateAttachment = 0x00000100,
        InvocationMaskHuawei          = 0x00040000,
        ShadingRateImage              = FragmentShadingRateAttachment,
        MaxEnumFlag                   = 0x7FFFFFFF
    }
}
