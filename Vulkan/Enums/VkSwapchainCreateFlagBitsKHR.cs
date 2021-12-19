using System;

namespace Vulkan
{
    [Flags]
    public enum VkSwapchainCreateFlagBitsKHR : uint
    {
        SplitInstanceBindRegions = 0x00000001,
        Protected                = 0x00000002,
        MutableFormat            = 0x00000004,
        MaxEnumFlag              = 0x7FFFFFFF
    }
}
