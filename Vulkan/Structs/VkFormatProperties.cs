using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkFormatProperties
    {
        [NativeTypeName("VkFormatFeatureFlags")]
        public VkFormatFeatureFlagBits LinearTilingFeatures;

        [NativeTypeName("VkFormatFeatureFlags")]
        public VkFormatFeatureFlagBits OptimalTilingFeatures;

        [NativeTypeName("VkFormatFeatureFlags")]
        public VkFormatFeatureFlagBits BufferFeatures;
    }
}
