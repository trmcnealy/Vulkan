using System;

namespace Vulkan
{
    [Flags]
    public enum VkDescriptorBindingFlagBits : uint
    {
        UpdateAfterBind          = 0x00000001,
        UpdateUnusedWhilePending = 0x00000002,
        PartiallyBound           = 0x00000004,
        VariableDescriptorCount  = 0x00000008,
        MaxEnumFlag              = 0x7FFFFFFF
    }
}
