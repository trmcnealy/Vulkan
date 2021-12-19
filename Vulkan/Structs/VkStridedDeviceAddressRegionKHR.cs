using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkStridedDeviceAddressRegionKHR
    {
        [NativeTypeName("VkDeviceAddress")] public ulong DeviceAddress;

        [NativeTypeName("VkDeviceSize")] public ulong Stride;

        [NativeTypeName("VkDeviceSize")] public ulong Size;
    }
}
