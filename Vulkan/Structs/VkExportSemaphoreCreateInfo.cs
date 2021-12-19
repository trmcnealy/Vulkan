using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExportSemaphoreCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkExternalSemaphoreHandleTypeFlags")]
        public uint HandleTypes;
    }
}
