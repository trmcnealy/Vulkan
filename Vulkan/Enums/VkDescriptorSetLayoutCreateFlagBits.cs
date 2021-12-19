using System;

namespace Vulkan
{
    [Flags]
    public enum VkDescriptorSetLayoutCreateFlagBits : uint
    {
        UpdateAfterBindPool = 0x00000002,
        PushDescriptor      = 0x00000001,
        HostOnlyPoolValve   = 0x00000004,
        MaxEnumFlag         = 0x7FFFFFFF
    }
}
