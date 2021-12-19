using System;

namespace Vulkan
{
    [Flags]
    public enum VkCommandPoolCreateFlagBits : uint
    {
        Transient          = 0x00000001,
        ResetCommandBuffer = 0x00000002,
        Protected          = 0x00000004,
        MaxEnumFlag        = 0x7FFFFFFF
    }
}
