using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceImageFormatInfo2
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkFormat Format;

        public VkImageType Type;

        public VkImageTiling Tiling;

        [NativeTypeName("VkImageUsageFlags")] public uint Usage;

        [NativeTypeName("VkImageCreateFlags")] public uint Flags;
    }
}
