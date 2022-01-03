using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkWriteDescriptorSet
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkDescriptorSet")] public VkDescriptorSet DstSet;

        [NativeTypeName("uint32_t")] public uint DstBinding;

        [NativeTypeName("uint32_t")] public uint DstArrayElement;

        [NativeTypeName("uint32_t")] public uint DescriptorCount;

        public VkDescriptorType DescriptorType;

        [NativeTypeName("const VkDescriptorImageInfo *")]
        public VkDescriptorImageInfo* PImageInfo;

        [NativeTypeName("const VkDescriptorBufferInfo *")]
        public VkDescriptorBufferInfo* PBufferInfo;

        [NativeTypeName("const VkBufferView *")]
        public VkBufferView* PTexelBufferView;
    }
}
