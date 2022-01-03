using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkFormatProperties3KHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("VkFormatFeatureFlags2KHR")]
        public ulong LinearTilingFeatures;

        [NativeTypeName("VkFormatFeatureFlags2KHR")]
        public ulong OptimalTilingFeatures;

        [NativeTypeName("VkFormatFeatureFlags2KHR")]
        public ulong BufferFeatures;
    }
}
