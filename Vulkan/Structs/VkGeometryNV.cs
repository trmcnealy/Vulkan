using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkGeometryNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkGeometryTypeKHR GeometryType;

        public VkGeometryDataNV Geometry;

        [NativeTypeName("VkGeometryFlagsKHR")] public uint Flags;
    }
}
