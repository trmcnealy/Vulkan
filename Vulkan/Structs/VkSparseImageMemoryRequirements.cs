using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseImageMemoryRequirements
    {
        public VkSparseImageFormatProperties FormatProperties;

        [NativeTypeName("uint32_t")] public uint ImageMipTailFirstLod;

        [NativeTypeName("ulong")] public ulong ImageMipTailSize;

        [NativeTypeName("ulong")] public ulong ImageMipTailOffset;

        [NativeTypeName("ulong")] public ulong ImageMipTailStride;
    }
}
