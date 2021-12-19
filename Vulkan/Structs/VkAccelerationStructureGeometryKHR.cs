using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureGeometryKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkGeometryTypeKHR GeometryType;

        public VkAccelerationStructureGeometryDataKHR Geometry;

        [NativeTypeName("VkGeometryFlagsKHR")] public uint Flags;
    }
}
