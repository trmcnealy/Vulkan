using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkFormatProperties2
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        public VkFormatProperties FormatProperties;
    }
}
