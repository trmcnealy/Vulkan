using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFeatures2
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkPhysicalDeviceFeatures Features;
    }
}
