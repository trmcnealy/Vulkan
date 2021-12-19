using System;

namespace Vulkan
{
    [Flags]
    public enum VkCommandPoolResetFlagBits : uint
    {
        ReleaseResources = 0x00000001,
        MaxEnumFlag      = 0x7FFFFFFF
    }
}
