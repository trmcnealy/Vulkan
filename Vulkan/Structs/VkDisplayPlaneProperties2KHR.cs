using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayPlaneProperties2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkDisplayPlanePropertiesKHR DisplayPlaneProperties;
    }
}
