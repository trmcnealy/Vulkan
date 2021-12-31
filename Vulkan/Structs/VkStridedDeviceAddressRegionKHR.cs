using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkStridedDeviceAddressRegionKHR
    {
        [NativeTypeName("VkDeviceAddress")] public ulong DeviceAddress;

        [NativeTypeName("ulong")] public ulong Stride;

        [NativeTypeName("ulong")] public ulong Size;
    }
}
