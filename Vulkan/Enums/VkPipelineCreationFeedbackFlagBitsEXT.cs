using System;

namespace Vulkan
{
    [Flags]
    public enum VkPipelineCreationFeedbackFlagBitsEXT : uint
    {
        Valid                       = 0x00000001,
        ApplicationPipelineCacheHit = 0x00000002,
        BasePipelineAcceleration    = 0x00000004,
        MaxEnumFlag                 = 0x7FFFFFFF
    }
}
