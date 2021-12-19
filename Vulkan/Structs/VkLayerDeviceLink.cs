using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkLayerDeviceLink
    {
        [NativeTypeName("struct VkLayerDeviceLink_ *")]
        public VkLayerDeviceLink* PNext;

        [NativeTypeName("PFN_vkGetInstanceProcAddr")]
        public nint PfnNextGetInstanceProcAddr;

        [NativeTypeName("PFN_vkGetDeviceProcAddr")]
        public nint PfnNextGetDeviceProcAddr;
    }
}
