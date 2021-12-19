using System;

namespace Vulkan
{
    [Flags]
    public enum VkPipelineCacheCreateFlagBits : uint
    {
        ExternallySynchronized = 0x00000001,
        MaxEnumFlag            = 0x7FFFFFFF
    }
}
