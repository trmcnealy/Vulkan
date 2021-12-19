using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkQueueFamilyProperties
    {
        [NativeTypeName("VkQueueFlags")] public VkQueueFlagBits QueueFlags;

        [NativeTypeName("uint32_t")] public uint QueueCount;

        [NativeTypeName("uint32_t")] public uint TimestampValidBits;

        public VkExtent3D MinImageTransferGranularity;
    }
}
