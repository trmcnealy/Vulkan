using System;

namespace Vulkan
{
    [Flags]
    public enum VkMemoryPropertyFlagBits : uint
    {
        DeviceLocal     = 0x00000001,
        HostVisible     = 0x00000002,
        HostCoherent    = 0x00000004,
        HostCached      = 0x00000008,
        LazilyAllocated = 0x00000010,
        Protected       = 0x00000020,
        DeviceCoherent  = 0x00000040,
        DeviceUncached  = 0x00000080,
        RdmaCapable     = 0x00000100,
        MaxEnumFlag     = 0x7FFFFFFF
    }
}
