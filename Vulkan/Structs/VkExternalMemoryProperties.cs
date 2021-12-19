using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExternalMemoryProperties
    {
        [NativeTypeName("VkExternalMemoryFeatureFlags")]
        public uint ExternalMemoryFeatures;

        [NativeTypeName("VkExternalMemoryHandleTypeFlags")]
        public uint ExportFromImportedHandleTypes;

        [NativeTypeName("VkExternalMemoryHandleTypeFlags")]
        public uint CompatibleHandleTypes;
    }
}
