using System;

namespace Vulkan
{
    [Flags]
    public enum VkCommandBufferUsageFlagBits : uint
    {
        OneTimeSubmit      = 0x00000001,
        RenderPassContinue = 0x00000002,
        SimultaneousUse    = 0x00000004,
        MaxEnumFlag        = 0x7FFFFFFF
    }
}
