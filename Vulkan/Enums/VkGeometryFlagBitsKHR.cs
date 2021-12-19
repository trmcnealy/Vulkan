using System;

namespace Vulkan
{
    [Flags]
    public enum VkGeometryFlagBitsKHR : uint
    {
        Opaque                      = 0x00000001,
        NoDuplicateAnyHitInvocation = 0x00000002,
        MaxEnumFlag                 = 0x7FFFFFFF
    }
}
