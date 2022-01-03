using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAcquireNextImageInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkSwapchainKHR")] public VkSwapchainKHR Swapchain;

        [NativeTypeName("uint64_t")] public ulong Timeout;

        [NativeTypeName("VkSemaphore")] public VkSemaphore Semaphore;

        [NativeTypeName("VkFence")] public VkFence Fence;

        [NativeTypeName("uint32_t")] public uint DeviceMask;
    }
}
