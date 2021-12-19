using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCommandBufferAllocateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nint PNext;

        [NativeTypeName("VkCommandPool")]
        public VkCommandPool CommandPool;

        public VkCommandBufferLevel Level;

        [NativeTypeName("uint32_t")]
        public uint CommandBufferCount;
    }
}
