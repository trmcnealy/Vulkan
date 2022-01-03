using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkFramebufferMixedSamplesCombinationNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        public VkCoverageReductionModeNV CoverageReductionMode;

        public VkSampleCountFlagBits RasterizationSamples;

        [NativeTypeName("VkSampleCountFlags")] public uint DepthStencilSamples;

        [NativeTypeName("VkSampleCountFlags")] public uint ColorSamples;
    }
}
