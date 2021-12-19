using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkWriteDescriptorSetInlineUniformBlockEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint DataSize;

        [NativeTypeName("const void *")] public nint PData;
    }
}
