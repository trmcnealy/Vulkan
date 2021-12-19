using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShaderCorePropertiesAMD
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint ShaderEngineCount;

        [NativeTypeName("uint32_t")] public uint ShaderArraysPerEngineCount;

        [NativeTypeName("uint32_t")] public uint ComputeUnitsPerShaderArray;

        [NativeTypeName("uint32_t")] public uint SimdPerComputeUnit;

        [NativeTypeName("uint32_t")] public uint WavefrontsPerSimd;

        [NativeTypeName("uint32_t")] public uint WavefrontSize;

        [NativeTypeName("uint32_t")] public uint SgprsPerSimd;

        [NativeTypeName("uint32_t")] public uint MinSgprAllocation;

        [NativeTypeName("uint32_t")] public uint MaxSgprAllocation;

        [NativeTypeName("uint32_t")] public uint SgprAllocationGranularity;

        [NativeTypeName("uint32_t")] public uint VgprsPerSimd;

        [NativeTypeName("uint32_t")] public uint MinVgprAllocation;

        [NativeTypeName("uint32_t")] public uint MaxVgprAllocation;

        [NativeTypeName("uint32_t")] public uint VgprAllocationGranularity;
    }
}
