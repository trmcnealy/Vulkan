using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkGeneratedCommandsMemoryRequirementsInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkPipelineBindPoint PipelineBindPoint;

        [NativeTypeName("VkPipeline")] public VkPipeline Pipeline;

        [NativeTypeName("VkIndirectCommandsLayoutNV")]
        public VkIndirectCommandsLayoutNV IndirectCommandsLayout;

        [NativeTypeName("uint32_t")] public uint MaxSequencesCount;
    }
}
