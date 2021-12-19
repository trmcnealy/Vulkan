using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDescriptorSetLayoutBinding
    {
        [NativeTypeName("uint32_t")]
        public uint Binding;

        public VkDescriptorType DescriptorType;

        [NativeTypeName("uint32_t")]
        public uint DescriptorCount;

        [NativeTypeName("VkShaderStageFlags")]
        public VkShaderStageFlagBits StageFlags;

        [NativeTypeName("const VkSampler *")]
        public VkSampler* PImmutableSamplers;
    }
}
