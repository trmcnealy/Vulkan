using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineColorBlendAttachmentState
    {
        [NativeTypeName("VkBool32")] public uint BlendEnable;

        public VkBlendFactor SrcColorBlendFactor;

        public VkBlendFactor DstColorBlendFactor;

        public VkBlendOp ColorBlendOp;

        public VkBlendFactor SrcAlphaBlendFactor;

        public VkBlendFactor DstAlphaBlendFactor;

        public VkBlendOp AlphaBlendOp;

        [NativeTypeName("VkColorComponentFlags")]
        public VkColorComponentFlagBits ColorWriteMask;
    }
}
