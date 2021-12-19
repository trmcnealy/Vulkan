using System;

namespace Vulkan
{
    [Flags]
    public enum VkImageViewCreateFlagBits : uint
    {
        FragmentDensityMapDynamic  = 0x00000001,
        FragmentDensityMapDeferred = 0x00000002,
        MaxEnumFlag                = 0x7FFFFFFF
    }
}
