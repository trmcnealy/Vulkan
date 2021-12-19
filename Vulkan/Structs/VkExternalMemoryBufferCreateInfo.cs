using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExternalMemoryBufferCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkExternalMemoryHandleTypeFlags")]
        public uint HandleTypes;
    }
}
