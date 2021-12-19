using System;

namespace Vulkan
{
    [Flags]
    public enum VkDeviceGroupPresentModeFlagBitsKHR : uint
    {
        Local            = 0x00000001,
        Remote           = 0x00000002,
        Sum              = 0x00000004,
        LocalMultiDevice = 0x00000008,
        MaxEnumFlag      = 0x7FFFFFFF
    }
}
