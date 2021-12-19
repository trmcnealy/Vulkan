using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImportSemaphoreFdInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkSemaphore")] public VkSemaphore Semaphore;

        [NativeTypeName("VkSemaphoreImportFlags")]
        public uint Flags;

        public VkExternalSemaphoreHandleTypeFlagBits HandleType;

        public int Fd;
    }
}
