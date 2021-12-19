using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkGeometryTrianglesNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkBuffer")] public VkBuffer VertexData;

        [NativeTypeName("VkDeviceSize")] public ulong VertexOffset;

        [NativeTypeName("uint32_t")] public uint VertexCount;

        [NativeTypeName("VkDeviceSize")] public ulong VertexStride;

        public VkFormat VertexFormat;

        [NativeTypeName("VkBuffer")] public VkBuffer IndexData;

        [NativeTypeName("VkDeviceSize")] public ulong IndexOffset;

        [NativeTypeName("uint32_t")] public uint IndexCount;

        public VkIndexType IndexType;

        [NativeTypeName("VkBuffer")] public VkBuffer TransformData;

        [NativeTypeName("VkDeviceSize")] public ulong TransformOffset;
    }
}
