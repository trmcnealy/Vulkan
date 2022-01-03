using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceSparseImageFormatInfo2
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkFormat Format;

        public VkImageType Type;

        public VkSampleCountFlagBits Samples;

        [NativeTypeName("VkImageUsageFlags")] public uint Usage;

        public VkImageTiling Tiling;
    }
}
