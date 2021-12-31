using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineRasterizationStateCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkPipelineRasterizationStateCreateFlags")]
        public uint Flags;

        [NativeTypeName("Bool32")] public uint DepthClampEnable;

        [NativeTypeName("Bool32")] public uint RasterizerDiscardEnable;

        public VkPolygonMode PolygonMode;

        [NativeTypeName("VkCullModeFlags")] public VkCullModeFlagBits CullMode;

        public VkFrontFace FrontFace;

        [NativeTypeName("Bool32")] public uint DepthBiasEnable;

        public float DepthBiasConstantFactor;

        public float DepthBiasClamp;

        public float DepthBiasSlopeFactor;

        public float LineWidth;
    }
}
