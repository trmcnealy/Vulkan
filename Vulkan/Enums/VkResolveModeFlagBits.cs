using System;

namespace Vulkan
{
    [Flags]
    public enum VkResolveModeFlagBits : uint
    {
        None        = 0,
        SampleZero  = 0x00000001,
        Average     = 0x00000002,
        Min         = 0x00000004,
        Max         = 0x00000008,
        MaxEnumFlag = 0x7FFFFFFF
    }
}
