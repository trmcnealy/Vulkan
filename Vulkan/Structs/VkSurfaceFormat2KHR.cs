using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSurfaceFormat2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkSurfaceFormatKHR SurfaceFormat;
    }
}
