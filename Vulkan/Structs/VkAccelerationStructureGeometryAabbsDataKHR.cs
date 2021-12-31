using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureGeometryAabbsDataKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkDeviceOrHostAddressConstKHR Data;

        [NativeTypeName("ulong")] public ulong Stride;
    }
}
