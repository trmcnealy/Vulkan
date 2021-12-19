using System;

namespace Vulkan
{
    [Flags]
    public enum VkImageCreateFlagBits : uint
    {
        SparseBinding                  = 0x00000001,
        SparseResidency                = 0x00000002,
        SparseAliased                  = 0x00000004,
        MutableFormat                  = 0x00000008,
        CubeCompatible                 = 0x00000010,
        Alias                          = 0x00000400,
        SplitInstanceBindRegions       = 0x00000040,
        Array2DCompatible              = 0x00000020,
        BlockexelViewCompatible        = 0x00000080,
        TendedUsage                    = 0x00000100,
        Protected                      = 0x00000800,
        Disjoint                       = 0x00000200,
        CornerSampled                  = 0x00002000,
        SampleLocationsCompatibleDepth = 0x00001000,
        Subsampled                     = 0x00004000,
        MaxEnumFlag                    = 0x7FFFFFFF
    }
}
