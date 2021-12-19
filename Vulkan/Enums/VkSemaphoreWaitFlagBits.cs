using System;

namespace Vulkan
{
    [Flags]
    public enum VkSemaphoreWaitFlagBits : uint
    {
        Any         = 0x00000001,
        MaxEnumFlag = 0x7FFFFFFF
    }
}
