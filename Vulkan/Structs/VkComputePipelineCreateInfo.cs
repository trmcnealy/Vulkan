using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkComputePipelineCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nint PNext;

        [NativeTypeName("VkPipelineCreateFlags")]
        public uint Flags;

        public VkPipelineShaderStageCreateInfo Stage;

        [NativeTypeName("VkPipelineLayout")]
        public VkPipelineLayout Layout;

        [NativeTypeName("VkPipeline")]
        public VkPipeline BasePipelineHandle;

        [NativeTypeName("int32_t")]
        public int BasePipelineIndex;
    }
}
