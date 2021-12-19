using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDrmFormatModifierPropertiesEXT
    {
        [NativeTypeName("uint64_t")] public ulong DrmFormatModifier;

        [NativeTypeName("uint32_t")] public uint DrmFormatModifierPlaneCount;

        [NativeTypeName("VkFormatFeatureFlags")]
        public uint DrmFormatModifierTilingFeatures;
    }
}
