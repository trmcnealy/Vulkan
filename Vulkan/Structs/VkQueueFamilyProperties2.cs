using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkQueueFamilyProperties2
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        public VkQueueFamilyProperties QueueFamilyProperties;
    }
}
