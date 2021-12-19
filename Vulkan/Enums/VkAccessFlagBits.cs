using System;

namespace Vulkan
{
    [Flags]
    public enum VkAccessFlagBits : uint
    {
        IndirectCommandRead               = 0x00000001,
        IndexRead                         = 0x00000002,
        VertexAttributeRead               = 0x00000004,
        UniformRead                       = 0x00000008,
        InputAttachmentRead               = 0x00000010,
        ShaderRead                        = 0x00000020,
        ShaderWrite                       = 0x00000040,
        ColorAttachmentRead               = 0x00000080,
        ColorAttachmentWrite              = 0x00000100,
        DepthStencilAttachmentRead        = 0x00000200,
        DepthStencilAttachmentWrite       = 0x00000400,
        TransferRead                      = 0x00000800,
        TransferWrite                     = 0x00001000,
        HostRead                          = 0x00002000,
        HostWrite                         = 0x00004000,
        MemoryRead                        = 0x00008000,
        MemoryWrite                       = 0x00010000,
        Write                             = 0x02000000,
        CounterRead                       = 0x04000000,
        CounterWrite                      = 0x08000000,
        ConditionalRenderingRead          = 0x00100000,
        ColorAttachmentReadNoncoherent    = 0x00080000,
        AccelerationStructureRead         = 0x00200000,
        AccelerationStructureWrite        = 0x00400000,
        FragmentDensityMapRead            = 0x01000000,
        FragmentShadingRateAttachmentRead = 0x00800000,
        CommandPreprocessRead             = 0x00020000,
        CommandPreprocessWrite            = 0x00040000,
        None                              = 0,
        ShadingRateImageRead              = FragmentShadingRateAttachmentRead,
        MaxEnumFlag                       = 0x7FFFFFFF
    }
}
