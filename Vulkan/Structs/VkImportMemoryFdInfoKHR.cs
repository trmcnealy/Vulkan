using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImportMemoryFdInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkExternalMemoryHandleTypeFlagBits HandleType;

        public int Fd;
    }
}
