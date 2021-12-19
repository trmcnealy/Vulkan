using System;

namespace Vulkan
{
    [Flags]
    public enum VkSamplerCreateFlagBits : uint
    {
        Subsampled                     = 0x00000001,
        SubsampledCoarseReconstruction = 0x00000002,
        MaxEnumFlag                    = 0x7FFFFFFF
    }
}
