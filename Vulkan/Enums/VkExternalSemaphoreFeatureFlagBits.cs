using System;

namespace Vulkan
{
    [Flags]
    public enum VkExternalSemaphoreFeatureFlagBits : uint
    {
        VkernalSemaphoreFeatureExportable = 0x00000001,
        VkernalSemaphoreFeatureImportable = 0x00000002,
        MaxEnumFlag                       = 0x7FFFFFFF
    }
}
