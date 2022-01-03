using System;

namespace Vulkan
{
    [Flags]
    public enum VkQueueFlagBits : uint
    {
        Unknown       = 0x00000000,
        Graphics      = 0x00000001,
        Compute       = 0x00000002,
        Transfer      = 0x00000004,
        SparseBinding = 0x00000008,
        Protected     = 0x00000010,
        MaxEnumFlag   = 0x7FFFFFFF
    }
}
