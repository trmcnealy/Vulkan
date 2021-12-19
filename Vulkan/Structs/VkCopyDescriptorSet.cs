using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCopyDescriptorSet
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkDescriptorSet")] public VkDescriptorSet SrcSet;

        [NativeTypeName("uint32_t")] public uint SrcBinding;

        [NativeTypeName("uint32_t")] public uint SrcArrayElement;

        [NativeTypeName("VkDescriptorSet")] public VkDescriptorSet DstSet;

        [NativeTypeName("uint32_t")] public uint DstBinding;

        [NativeTypeName("uint32_t")] public uint DstArrayElement;

        [NativeTypeName("uint32_t")] public uint DescriptorCount;
    }
}
