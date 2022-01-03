using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPhysicalDeviceMeshShaderPropertiesNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint MaxDrawMeshTasksCount;

        [NativeTypeName("uint32_t")] public uint MaxTaskWorkGroupInvocations;

        [NativeTypeName("uint32_t [3]")] public fixed uint MaxTaskWorkGroupSize[3];

        [NativeTypeName("uint32_t")] public uint MaxTaskTotalMemorySize;

        [NativeTypeName("uint32_t")] public uint MaxTaskOutputCount;

        [NativeTypeName("uint32_t")] public uint MaxMeshWorkGroupInvocations;

        [NativeTypeName("uint32_t [3]")] public fixed uint MaxMeshWorkGroupSize[3];

        [NativeTypeName("uint32_t")] public uint MaxMeshTotalMemorySize;

        [NativeTypeName("uint32_t")] public uint MaxMeshOutputVertices;

        [NativeTypeName("uint32_t")] public uint MaxMeshOutputPrimitives;

        [NativeTypeName("uint32_t")] public uint MaxMeshMultiviewViewCount;

        [NativeTypeName("uint32_t")] public uint MeshOutputPerVertexGranularity;

        [NativeTypeName("uint32_t")] public uint MeshOutputPerPrimitiveGranularity;
    }
}
