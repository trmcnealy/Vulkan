using System;

namespace Vulkan
{
    [Flags]
    public enum VkBufferUsageFlagBits : uint
    {
        TransferSrc                             = 0x00000001,
        TransferDst                             = 0x00000002,
        UniformexelBuffer                       = 0x00000004,
        StorageexelBuffer                       = 0x00000008,
        UniformBuffer                           = 0x00000010,
        StorageBuffer                           = 0x00000020,
        IndexBuffer                             = 0x00000040,
        VertexBuffer                            = 0x00000080,
        IndirectBuffer                          = 0x00000100,
        ShaderDeviceAddress                     = 0x00020000,
        RansformFeedbackBuffer                  = 0x00000800,
        RansformFeedbackCounterBuffer           = 0x00001000,
        ConditionalRendering                    = 0x00000200,
        AccelerationStructureBuildInputReadOnly = 0x00080000,
        AccelerationStructureStorage            = 0x00100000,
        ShaderBindingable                       = 0x00000400,
        Rayracing                               = ShaderBindingable,
        MaxEnumFlag                             = 0x7FFFFFFF
    }
}
