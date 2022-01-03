using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureGeometryMotionTrianglesDataNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkDeviceOrHostAddressConstKHR VertexData;
    }
}
