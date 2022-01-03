using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkFramebufferAttachmentImageInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkImageCreateFlags")] public uint Flags;

        [NativeTypeName("VkImageUsageFlags")] public uint Usage;

        [NativeTypeName("uint32_t")] public uint Width;

        [NativeTypeName("uint32_t")] public uint Height;

        [NativeTypeName("uint32_t")] public uint LayerCount;

        [NativeTypeName("uint32_t")] public uint ViewFormatCount;

        [NativeTypeName("const VkFormat *")] public VkFormat* PViewFormats;
    }
}
