using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCommandBufferInheritanceInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkRenderPass")] public VkRenderPass RenderPass;

        [NativeTypeName("uint32_t")] public uint Subpass;

        [NativeTypeName("VkFramebuffer")] public VkFramebuffer Framebuffer;

        [NativeTypeName("Bool32")] public uint OcclusionQueryEnable;

        [NativeTypeName("VkQueryControlFlags")]
        public uint QueryFlags;

        [NativeTypeName("VkQueryPipelineStatisticFlags")]
        public uint PipelineStatistics;
    }
}
