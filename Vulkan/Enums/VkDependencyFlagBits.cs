using System;

namespace Vulkan
{
    [Flags]
    public enum VkDependencyFlagBits : uint
    {
        ByRegion    = 0x00000001,
        DeviceGroup = 0x00000004,
        ViewLocal   = 0x00000002,
        MaxEnumFlag = 0x7FFFFFFF
    }
}
