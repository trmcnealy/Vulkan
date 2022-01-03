using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceQueueInfo2
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nuint PNext;

        [NativeTypeName("VkDeviceQueueCreateFlags")]
        public VkDeviceQueueCreateFlagBits Flags;

        [NativeTypeName("uint32_t")]
        public uint QueueFamilyIndex;

        [NativeTypeName("uint32_t")]
        public uint QueueIndex;
    }
}
