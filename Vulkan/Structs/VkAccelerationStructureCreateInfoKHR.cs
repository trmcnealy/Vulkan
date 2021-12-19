using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureCreateInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkAccelerationStructureCreateFlagsKHR")]
        public uint CreateFlags;

        [NativeTypeName("VkBuffer")] public VkBuffer Buffer;

        [NativeTypeName("VkDeviceSize")] public ulong Offset;

        [NativeTypeName("VkDeviceSize")] public ulong Size;

        public VkAccelerationStructureTypeKHR Type;

        [NativeTypeName("VkDeviceAddress")] public ulong DeviceAddress;
    }
}
