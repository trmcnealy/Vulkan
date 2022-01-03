using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayProperties2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        public VkDisplayPropertiesKHR DisplayProperties;
    }
}
