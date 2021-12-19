using System;

namespace Vulkan
{
    [Flags]
    public enum VkFramebufferCreateFlagBits : uint
    {
        Imageless   = 0x00000001,
        MaxEnumFlag = 0x7FFFFFFF
    }
}
