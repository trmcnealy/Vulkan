using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct VkAccelerationStructureGeometryDataKHR
    {
        [FieldOffset(0)] public VkAccelerationStructureGeometryTrianglesDataKHR triangles;

        [FieldOffset(0)] public VkAccelerationStructureGeometryAabbsDataKHR aabbs;

        [FieldOffset(0)] public VkAccelerationStructureGeometryInstancesDataKHR instances;
    }
}
