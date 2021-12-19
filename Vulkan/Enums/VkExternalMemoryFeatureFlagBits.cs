using System;

namespace Vulkan
{
    [Flags]
    public enum VkExternalMemoryFeatureFlagBits : uint
    {
        VkernalMemoryFeatureDedicatedOnly = 0x00000001,
        VkernalMemoryFeatureExportable    = 0x00000002,
        VkernalMemoryFeatureImportable    = 0x00000004,
        MaxEnumFlag                       = 0x7FFFFFFF
    }
}
