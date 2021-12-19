using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDeviceGroupPresentInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint SwapchainCount;

        [NativeTypeName("const uint32_t *")] public uint* PDeviceMasks;

        public VkDeviceGroupPresentModeFlagBitsKHR Mode;
    }
}
