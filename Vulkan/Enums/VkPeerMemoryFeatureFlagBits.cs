using System;

namespace Vulkan
{
    [Flags]
    public enum VkPeerMemoryFeatureFlagBits : uint
    {
        CopySrc     = 0x00000001,
        CopyDst     = 0x00000002,
        GenericSrc  = 0x00000004,
        GenericDst  = 0x00000008,
        MaxEnumFlag = 0x7FFFFFFF
    }
}
