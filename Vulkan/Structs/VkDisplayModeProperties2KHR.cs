using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayModeProperties2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkDisplayModePropertiesKHR DisplayModeProperties;
    }
}
