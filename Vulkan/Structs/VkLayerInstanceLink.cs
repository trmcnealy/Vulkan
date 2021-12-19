using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkLayerInstanceLink
    {
        [NativeTypeName("struct VkLayerInstanceLink_ *")]
        public VkLayerInstanceLink* PNext;

        [NativeTypeName("PFN_vkGetInstanceProcAddr")]
        public nint PfnNextGetInstanceProcAddr;

        [NativeTypeName("PFN_GetPhysicalDeviceProcAddr")]
        public nint PfnNextGetPhysicalDeviceProcAddr;
    }
}
