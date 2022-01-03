using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureCreateInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkAccelerationStructureCreateFlagsKHR")]
        public uint CreateFlags;

        [NativeTypeName("VkBuffer")] public VkBuffer Buffer;

        [NativeTypeName("ulong")] public ulong Offset;

        [NativeTypeName("ulong")] public ulong Size;

        public VkAccelerationStructureTypeKHR Type;

        [NativeTypeName("VkDeviceAddress")] public ulong DeviceAddress;
    }
}
