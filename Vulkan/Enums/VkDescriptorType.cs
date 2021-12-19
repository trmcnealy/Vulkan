namespace Vulkan
{
    public enum VkDescriptorType : uint
    {
        Sampler                  = 0,
        CombinedImageSampler     = 1,
        SampledImage             = 2,
        StorageImage             = 3,
        UniformexelBuffer        = 4,
        StorageexelBuffer        = 5,
        UniformBuffer            = 6,
        StorageBuffer            = 7,
        UniformBufferDynamic     = 8,
        StorageBufferDynamic     = 9,
        InputAttachment          = 10,
        InlineUniformBlock       = 1000138000,
        AccelerationStructureKhr = 1000150000,
        AccelerationStructureNv  = 1000165000,
        MutableValve             = 1000351000,
        MaxEnumFlag              = 0x7FFFFFFF
    }
}
