using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseImageFormatProperties
    {
        [NativeTypeName("VkImageAspectFlags")] public uint AspectMask;

        public VkExtent3D ImageGranularity;

        [NativeTypeName("VkSparseImageFormatFlags")]
        public uint Flags;
    }
}
