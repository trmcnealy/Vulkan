using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseImageMemoryRequirements
    {
        public VkSparseImageFormatProperties FormatProperties;

        [NativeTypeName("uint32_t")] public uint ImageMipTailFirstLod;

        [NativeTypeName("VkDeviceSize")] public ulong ImageMipTailSize;

        [NativeTypeName("VkDeviceSize")] public ulong ImageMipTailOffset;

        [NativeTypeName("VkDeviceSize")] public ulong ImageMipTailStride;
    }
}
