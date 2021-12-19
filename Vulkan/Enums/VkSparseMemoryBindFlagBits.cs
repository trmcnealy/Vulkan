using System;

namespace Vulkan
{
    [Flags]
    public enum VkSparseMemoryBindFlagBits : uint
    {
        Metadata    = 0x00000001,
        MaxEnumFlag = 0x7FFFFFFF
    }
}
