using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayPlaneCapabilities2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkDisplayPlaneCapabilitiesKHR Capabilities;
    }
}
