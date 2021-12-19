using System;

namespace Vulkan
{
    [Flags]
    public enum VkMemoryAllocateFlagBits : uint
    {
        DeviceMask                 = 0x00000001,
        DeviceAddress              = 0x00000002,
        DeviceAddressCaptureReplay = 0x00000004,
        MaxEnumFlag                = 0x7FFFFFFF
    }
}
