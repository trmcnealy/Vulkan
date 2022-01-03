using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageResolve2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkImageSubresourceLayers SrcSubresource;

        public VkOffset3D SrcOffset;

        public VkImageSubresourceLayers DstSubresource;

        public VkOffset3D DstOffset;

        public VkExtent3D Extent;
    }
}
