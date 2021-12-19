using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDrmFormatModifierProperties2EXT
    {
        [NativeTypeName("uint64_t")] public ulong DrmFormatModifier;

        [NativeTypeName("uint32_t")] public uint DrmFormatModifierPlaneCount;

        [NativeTypeName("VkFormatFeatureFlags2KHR")]
        public ulong DrmFormatModifierTilingFeatures;
    }
}
