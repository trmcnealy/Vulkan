using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImportFenceFdInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkFence")] public VkFence Fence;

        [NativeTypeName("VkFenceImportFlags")] public uint Flags;

        public VkExternalFenceHandleTypeFlagBits HandleType;

        public int Fd;
    }
}
