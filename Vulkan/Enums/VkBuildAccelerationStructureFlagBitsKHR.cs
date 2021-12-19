using System;

namespace Vulkan
{
    [Flags]
    public enum VkBuildAccelerationStructureFlagBitsKHR : uint
    {
        AllowUpdate     = 0x00000001,
        AllowCompaction = 0x00000002,
        PreferFastrace  = 0x00000004,
        PreferFastBuild = 0x00000008,
        LowMemory       = 0x00000010,
        Motion          = 0x00000020,
        MaxEnumFlag     = 0x7FFFFFFF
    }
}
