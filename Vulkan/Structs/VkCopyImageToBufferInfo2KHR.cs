using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkCopyImageToBufferInfo2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkImage")] public VkImage SrcImage;

        public VkImageLayout SrcImageLayout;

        [NativeTypeName("VkBuffer")] public VkBuffer DstBuffer;

        [NativeTypeName("uint32_t")] public uint RegionCount;

        [NativeTypeName("const VkBufferImageCopy2KHR *")]
        public VkBufferImageCopy2KHR* PRegions;
    }
}
