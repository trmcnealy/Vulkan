using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPhysicalDeviceIDProperties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("uint8_t [16]")]
        public Fixed<byte, Const.UInt16> DeviceUuid; //[16];

        [NativeTypeName("uint8_t [16]")]
        public Fixed<byte, Const.UInt16> DriverUuid; //[16];

        [NativeTypeName("uint8_t [8]")]
        public Fixed<byte, Const.UInt8> DeviceLuid; //[8];

        [NativeTypeName("uint32_t")] public uint DeviceNodeMask;

        [NativeTypeName("Bool32")] public uint DeviceLuidValid;
    }
}
