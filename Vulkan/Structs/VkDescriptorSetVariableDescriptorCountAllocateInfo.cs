using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint DescriptorSetCount;

        [NativeTypeName("const uint32_t *")] public uint* PDescriptorCounts;
    }
}
