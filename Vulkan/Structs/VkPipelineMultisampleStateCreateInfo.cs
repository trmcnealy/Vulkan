using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineMultisampleStateCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkPipelineMultisampleStateCreateFlags")]
        public uint Flags;

        public VkSampleCountFlagBits RasterizationSamples;

        [NativeTypeName("Bool32")] public uint SampleShadingEnable;

        public float MinSampleShading;

        [NativeTypeName("const VkSampleMask *")]
        public uint* PSampleMask;

        [NativeTypeName("Bool32")] public uint AlphaToCoverageEnable;

        [NativeTypeName("Bool32")] public uint AlphaToOneEnable;
    }
}
