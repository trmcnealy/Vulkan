using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageCopy
    {
        public VkImageSubresourceLayers SrcSubresource;

        public VkOffset3D SrcOffset;

        public VkImageSubresourceLayers DstSubresource;

        public VkOffset3D DstOffset;

        public VkExtent3D Extent;
    }
}
