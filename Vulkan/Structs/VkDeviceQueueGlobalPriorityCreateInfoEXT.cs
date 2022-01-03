using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceQueueGlobalPriorityCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkQueueGlobalPriorityEXT GlobalPriority;
    }
}
