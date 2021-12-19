using System;

namespace Vulkan
{
    [Flags]
    public enum VkExternalFenceFeatureFlagBits : uint
    {
        VkernalFenceFeatureExportable = 0x00000001,
        VkernalFenceFeatureImportable = 0x00000002,
        MaxEnumFlag                   = 0x7FFFFFFF
    }
}
