using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkLayerDeviceInfo
    {
        [NativeTypeName("void *")] public nint DeviceInfo;

        [NativeTypeName("PFN_vkGetInstanceProcAddr")]
        public nint PfnNextGetInstanceProcAddr;
    }
}
