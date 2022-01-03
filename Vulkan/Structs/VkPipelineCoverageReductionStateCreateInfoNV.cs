using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineCoverageReductionStateCreateInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkPipelineCoverageReductionStateCreateFlagsNV")]
        public uint Flags;

        public VkCoverageReductionModeNV CoverageReductionMode;
    }
}
