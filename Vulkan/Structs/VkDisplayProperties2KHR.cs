using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayProperties2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkDisplayPropertiesKHR DisplayProperties;
    }
}
