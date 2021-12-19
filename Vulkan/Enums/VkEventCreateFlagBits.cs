using System;

namespace Vulkan
{
    [Flags]
    public enum VkEventCreateFlagBits : uint
    {
        DeviceOnly  = 0x00000001,
        MaxEnumFlag = 0x7FFFFFFF
    }
}
