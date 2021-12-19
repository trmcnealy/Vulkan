using System;

namespace Vulkan
{
    [Flags]
    public enum VkMemoryHeapFlagBits : uint
    {
        DeviceLocal   = 0x00000001,
        MultiInstance = 0x00000002,
        MaxEnumFlag   = 0x7FFFFFFF
    }
}
