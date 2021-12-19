using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExternalImageFormatPropertiesNV
    {
        public VkImageFormatProperties ImageFormatProperties;

        [NativeTypeName("VkExternalMemoryFeatureFlagsNV")]
        public uint ExternalMemoryFeatures;

        [NativeTypeName("VkExternalMemoryHandleTypeFlagsNV")]
        public uint ExportFromImportedHandleTypes;

        [NativeTypeName("VkExternalMemoryHandleTypeFlagsNV")]
        public uint CompatibleHandleTypes;
    }
}
