using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceInlineUniformBlockPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint MaxInlineUniformBlockSize;

        [NativeTypeName("uint32_t")] public uint MaxPerStageDescriptorInlineUniformBlocks;

        [NativeTypeName("uint32_t")] public uint MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;

        [NativeTypeName("uint32_t")] public uint MaxDescriptorSetInlineUniformBlocks;

        [NativeTypeName("uint32_t")] public uint MaxDescriptorSetUpdateAfterBindInlineUniformBlocks;
    }
}
