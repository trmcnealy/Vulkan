using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPhysicalDeviceProperties
    {
        [NativeTypeName("uint32_t")] public uint ApiVersion;

        [NativeTypeName("uint32_t")] public uint DriverVersion;

        [NativeTypeName("uint32_t")] public uint VendorId;

        [NativeTypeName("uint32_t")] public uint DeviceId;

        public VkPhysicalDeviceType DeviceType;

        [NativeTypeName("char [256]")] public utf8string<Const.UInt256> DeviceName;

        [NativeTypeName("uint8_t [16]")] public Fixed<byte, Const.UInt16> PipelineCacheUuid;

        public VkPhysicalDeviceLimits Limits;

        public VkPhysicalDeviceSparseProperties SparseProperties;

        
        public utf8string DeviceNameAsUtf8String()
        {
            //fixed(sbyte* ptr = DeviceName)
            {
                return DeviceName.ToString();
            }
        }
    }
}
