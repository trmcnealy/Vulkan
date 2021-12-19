using System;

namespace Vulkan
{
    [Flags]
    public enum VkAccelerationStructureCreateFlagBitsKHR : uint
    {
        DeviceAddressCaptureReplay = 0x00000001,
        Motion                     = 0x00000004,
        MaxEnumFlag                = 0x7FFFFFFF
    }
}
