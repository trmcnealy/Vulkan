using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageViewAddressPropertiesNVX
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkDeviceAddress")] public ulong DeviceAddress;

        [NativeTypeName("ulong")] public ulong Size;
    }
}
