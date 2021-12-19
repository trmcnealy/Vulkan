namespace Vulkan
{
    public enum VkQueryType : uint
    {
        Occlusion                              = 0,
        PipelineStatistics                     = 1,
        Timestamp                              = 2,
        TransformFeedbackStream                = 1000028004,
        PerformanceQuery                       = 1000116000,
        AccelerationStructureCompactedSizeKhr  = 1000150000,
        AccelerationStructureSerializationSize = 1000150001,
        AccelerationStructureCompactedSizeNv   = 1000165000,
        PerformanceQueryIntel                  = 1000210000,
        MaxEnumFlag                            = 0x7FFFFFFF
    }
}
