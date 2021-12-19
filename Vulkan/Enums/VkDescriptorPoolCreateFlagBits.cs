using System;

namespace Vulkan
{
    [Flags]
    public enum VkDescriptorPoolCreateFlagBits : uint
    {
        FreeDescriptorSet = 0x00000001,
        UpdateAfterBind   = 0x00000002,
        HostOnlyValve     = 0x00000004,
        MaxEnumFlag       = 0x7FFFFFFF
    }
}
