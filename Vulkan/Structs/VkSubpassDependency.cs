using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubpassDependency
    {
        [NativeTypeName("uint32_t")]
        public uint SrcSubpass;

        [NativeTypeName("uint32_t")]
        public uint DstSubpass;

        [NativeTypeName("VkPipelineStageFlags")]
        public VkPipelineStageFlagBits SrcStageMask;

        [NativeTypeName("VkPipelineStageFlags")]
        public VkPipelineStageFlagBits DstStageMask;

        [NativeTypeName("VkAccessFlags")]
        public VkAccessFlagBits SrcAccessMask;

        [NativeTypeName("VkAccessFlags")]
        public VkAccessFlagBits DstAccessMask;

        [NativeTypeName("VkDependencyFlags")]
        public VkDependencyFlagBits DependencyFlags;
    }
}
