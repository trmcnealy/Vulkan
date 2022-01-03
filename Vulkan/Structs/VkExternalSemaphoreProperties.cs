using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExternalSemaphoreProperties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("VkExternalSemaphoreHandleTypeFlags")]
        public uint ExportFromImportedHandleTypes;

        [NativeTypeName("VkExternalSemaphoreHandleTypeFlags")]
        public uint CompatibleHandleTypes;

        [NativeTypeName("VkExternalSemaphoreFeatureFlags")]
        public uint ExternalSemaphoreFeatures;
    }
}
