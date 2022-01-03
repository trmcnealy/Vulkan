using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkGeometryTrianglesNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkBuffer")] public VkBuffer VertexData;

        [NativeTypeName("ulong")] public ulong VertexOffset;

        [NativeTypeName("uint32_t")] public uint VertexCount;

        [NativeTypeName("ulong")] public ulong VertexStride;

        public VkFormat VertexFormat;

        [NativeTypeName("VkBuffer")] public VkBuffer IndexData;

        [NativeTypeName("ulong")] public ulong IndexOffset;

        [NativeTypeName("uint32_t")] public uint IndexCount;

        public VkIndexType IndexType;

        [NativeTypeName("VkBuffer")] public VkBuffer TransformData;

        [NativeTypeName("ulong")] public ulong TransformOffset;
    }
}
