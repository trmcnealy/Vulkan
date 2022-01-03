using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceBufferDeviceAddressFeatures
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint BufferDeviceAddress;

        [NativeTypeName("Bool32")] public uint BufferDeviceAddressCaptureReplay;

        [NativeTypeName("Bool32")] public uint BufferDeviceAddressMultiDevice;
    }
}
