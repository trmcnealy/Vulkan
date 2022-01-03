using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageFormatProperties2
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        public VkImageFormatProperties ImageFormatProperties;
    }
}
