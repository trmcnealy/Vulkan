using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCommandBufferSubmitInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkCommandBuffer")] public VkCommandBuffer CommandBuffer;

        [NativeTypeName("uint32_t")] public uint DeviceMask;
    }
}
