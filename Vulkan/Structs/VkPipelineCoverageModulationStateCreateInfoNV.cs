using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineCoverageModulationStateCreateInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkPipelineCoverageModulationStateCreateFlagsNV")]
        public uint Flags;

        public VkCoverageModulationModeNV CoverageModulationMode;

        [NativeTypeName("Bool32")] public uint CoverageModulationTableEnable;

        [NativeTypeName("uint32_t")] public uint CoverageModulationTableCount;

        [NativeTypeName("const float *")] public float* PCoverageModulationTable;
    }
}
