using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSemaphoreGetFdInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkSemaphore")] public VkSemaphore Semaphore;

        public VkExternalSemaphoreHandleTypeFlagBits HandleType;
    }
}
