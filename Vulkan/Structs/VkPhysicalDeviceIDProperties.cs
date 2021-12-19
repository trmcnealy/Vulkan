using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPhysicalDeviceIDProperties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("uint8_t [16]")] public fixed byte DeviceUuid[16];

        [NativeTypeName("uint8_t [16]")] public fixed byte DriverUuid[16];

        [NativeTypeName("uint8_t [8]")] public fixed byte DeviceLuid[8];

        [NativeTypeName("uint32_t")] public uint DeviceNodeMask;

        [NativeTypeName("VkBool32")] public uint DeviceLuidValid;
    }
}
