using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint BufferDeviceAddress;

        [NativeTypeName("VkBool32")] public uint BufferDeviceAddressCaptureReplay;

        [NativeTypeName("VkBool32")] public uint BufferDeviceAddressMultiDevice;
    }
}
