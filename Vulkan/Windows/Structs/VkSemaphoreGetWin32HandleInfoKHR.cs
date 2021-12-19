using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    public struct VkSemaphoreGetWin32HandleInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkSemaphore")] public VkSemaphore Semaphore;

        public VkExternalSemaphoreHandleTypeFlagBits HandleType;
    }
}
