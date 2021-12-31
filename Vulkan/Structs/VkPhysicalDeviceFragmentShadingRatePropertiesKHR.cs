using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkExtent2D MinFragmentShadingRateAttachmentTexelSize;

        public VkExtent2D MaxFragmentShadingRateAttachmentTexelSize;

        [NativeTypeName("uint32_t")] public uint MaxFragmentShadingRateAttachmentTexelSizeAspectRatio;

        [NativeTypeName("Bool32")] public uint PrimitiveFragmentShadingRateWithMultipleViewports;

        [NativeTypeName("Bool32")] public uint LayeredShadingRateAttachments;

        [NativeTypeName("Bool32")] public uint FragmentShadingRateNonTrivialCombinerOps;

        public VkExtent2D MaxFragmentSize;

        [NativeTypeName("uint32_t")] public uint MaxFragmentSizeAspectRatio;

        [NativeTypeName("uint32_t")] public uint MaxFragmentShadingRateCoverageSamples;

        public VkSampleCountFlagBits MaxFragmentShadingRateRasterizationSamples;

        [NativeTypeName("Bool32")] public uint FragmentShadingRateWithShaderDepthStencilWrites;

        [NativeTypeName("Bool32")] public uint FragmentShadingRateWithSampleMask;

        [NativeTypeName("Bool32")] public uint FragmentShadingRateWithShaderSampleMask;

        [NativeTypeName("Bool32")] public uint FragmentShadingRateWithConservativeRasterization;

        [NativeTypeName("Bool32")] public uint FragmentShadingRateWithFragmentShaderInterlock;

        [NativeTypeName("Bool32")] public uint FragmentShadingRateWithCustomSampleLocations;

        [NativeTypeName("Bool32")] public uint FragmentShadingRateStrictMultiplyCombiner;
    }
}
