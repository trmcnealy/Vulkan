using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceRayTracingPropertiesNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint ShaderGroupHandleSize;

        [NativeTypeName("uint32_t")] public uint MaxRecursionDepth;

        [NativeTypeName("uint32_t")] public uint MaxShaderGroupStride;

        [NativeTypeName("uint32_t")] public uint ShaderGroupBaseAlignment;

        [NativeTypeName("uint64_t")] public ulong MaxGeometryCount;

        [NativeTypeName("uint64_t")] public ulong MaxInstanceCount;

        [NativeTypeName("uint64_t")] public ulong MaxTriangleCount;

        [NativeTypeName("uint32_t")] public uint MaxDescriptorSetAccelerationStructures;
    }
}
