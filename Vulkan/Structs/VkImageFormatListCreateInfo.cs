using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkImageFormatListCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint ViewFormatCount;

        [NativeTypeName("const VkFormat *")] public VkFormat* PViewFormats;
    }
}
