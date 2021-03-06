using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageViewUsageCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkImageUsageFlags")] public uint Usage;
    }
}
