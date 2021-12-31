using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureGeometryTrianglesDataKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkFormat VertexFormat;

        public VkDeviceOrHostAddressConstKHR VertexData;

        [NativeTypeName("ulong")] public ulong VertexStride;

        [NativeTypeName("uint32_t")] public uint MaxVertex;

        public VkIndexType IndexType;

        public VkDeviceOrHostAddressConstKHR IndexData;

        public VkDeviceOrHostAddressConstKHR TransformData;
    }
}
