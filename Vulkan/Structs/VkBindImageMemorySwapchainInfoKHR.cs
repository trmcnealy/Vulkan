using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBindImageMemorySwapchainInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkSwapchainKHR")] public VkSwapchainKHR Swapchain;

        [NativeTypeName("uint32_t")] public uint ImageIndex;
    }
}
