using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkNegotiateLayerInterface
    {
        public VkNegotiateLayerStructType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint LoaderLayerInterfaceVersion;

        [NativeTypeName("PFN_vkGetInstanceProcAddr")]
        public nint PfnGetInstanceProcAddr;

        [NativeTypeName("PFN_vkGetDeviceProcAddr")]
        public nint PfnGetDeviceProcAddr;

        [NativeTypeName("PFN_GetPhysicalDeviceProcAddr")]
        public nint PfnGetPhysicalDeviceProcAddr;
    }
}
