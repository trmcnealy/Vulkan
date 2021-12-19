using System;

namespace Vulkan
{
    [Flags]
    public enum VkIndirectCommandsLayoutUsageFlagBitsNV : uint
    {
        ExplicitPreprocess = 0x00000001,
        IndexedSequences   = 0x00000002,
        UnorderedSequences = 0x00000004,
        MaxEnumFlag        = 0x7FFFFFFF
    }
}
