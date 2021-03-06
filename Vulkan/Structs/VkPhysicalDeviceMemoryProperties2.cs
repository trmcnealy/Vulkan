using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceMemoryProperties2
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        public VkPhysicalDeviceMemoryProperties MemoryProperties;
    }
}
