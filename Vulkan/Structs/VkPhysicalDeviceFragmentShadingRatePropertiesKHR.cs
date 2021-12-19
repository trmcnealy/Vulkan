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

        [NativeTypeName("VkBool32")] public uint PrimitiveFragmentShadingRateWithMultipleViewports;

        [NativeTypeName("VkBool32")] public uint LayeredShadingRateAttachments;

        [NativeTypeName("VkBool32")] public uint FragmentShadingRateNonTrivialCombinerOps;

        public VkExtent2D MaxFragmentSize;

        [NativeTypeName("uint32_t")] public uint MaxFragmentSizeAspectRatio;

        [NativeTypeName("uint32_t")] public uint MaxFragmentShadingRateCoverageSamples;

        public VkSampleCountFlagBits MaxFragmentShadingRateRasterizationSamples;

        [NativeTypeName("VkBool32")] public uint FragmentShadingRateWithShaderDepthStencilWrites;

        [NativeTypeName("VkBool32")] public uint FragmentShadingRateWithSampleMask;

        [NativeTypeName("VkBool32")] public uint FragmentShadingRateWithShaderSampleMask;

        [NativeTypeName("VkBool32")] public uint FragmentShadingRateWithConservativeRasterization;

        [NativeTypeName("VkBool32")] public uint FragmentShadingRateWithFragmentShaderInterlock;

        [NativeTypeName("VkBool32")] public uint FragmentShadingRateWithCustomSampleLocations;

        [NativeTypeName("VkBool32")] public uint FragmentShadingRateStrictMultiplyCombiner;
    }
}
