using System;

namespace Vulkan
{
    [Flags]
    public enum VkBufferCreateFlagBits : uint
    {
        SparseBinding              = 0x00000001,
        SparseResidency            = 0x00000002,
        SparseAliased              = 0x00000004,
        Protected                  = 0x00000008,
        DeviceAddressCaptureReplay = 0x00000010,
        MaxEnumFlag                = 0x7FFFFFFF
    }
}
