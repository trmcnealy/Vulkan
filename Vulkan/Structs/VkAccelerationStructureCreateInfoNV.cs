using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureCreateInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkDeviceSize")] public ulong CompactedSize;

        public VkAccelerationStructureInfoNV Info;
    }
}
