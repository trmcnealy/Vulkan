using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureGeometryInstancesDataKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint ArrayOfPointers;

        public VkDeviceOrHostAddressConstKHR Data;
    }
}
