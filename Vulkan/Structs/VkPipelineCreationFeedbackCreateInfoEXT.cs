using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineCreationFeedbackCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkPipelineCreationFeedbackEXT* PPipelineCreationFeedback;

        [NativeTypeName("uint32_t")] public uint PipelineStageCreationFeedbackCount;

        public VkPipelineCreationFeedbackEXT* PPipelineStageCreationFeedbacks;
    }
}
