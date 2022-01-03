using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExternalFenceProperties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("VkExternalFenceHandleTypeFlags")]
        public uint ExportFromImportedHandleTypes;

        [NativeTypeName("VkExternalFenceHandleTypeFlags")]
        public uint CompatibleHandleTypes;

        [NativeTypeName("VkExternalFenceFeatureFlags")]
        public uint ExternalFenceFeatures;
    }
}
