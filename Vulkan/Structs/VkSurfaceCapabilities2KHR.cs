using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSurfaceCapabilities2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        public VkSurfaceCapabilitiesKHR SurfaceCapabilities;
    }
}
