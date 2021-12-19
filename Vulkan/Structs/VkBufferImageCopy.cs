using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBufferImageCopy
    {
        [NativeTypeName("VkDeviceSize")] public ulong BufferOffset;

        [NativeTypeName("uint32_t")] public uint BufferRowLength;

        [NativeTypeName("uint32_t")] public uint BufferImageHeight;

        public VkImageSubresourceLayers ImageSubresource;

        public VkOffset3D ImageOffset;

        public VkExtent3D ImageExtent;
    }
}
