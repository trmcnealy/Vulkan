using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExportFenceCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkExternalFenceHandleTypeFlags")]
        public uint HandleTypes;
    }
}
