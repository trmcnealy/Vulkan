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

        [NativeTypeName("char [256]")] public fixed sbyte DeviceName[256];

        [NativeTypeName("uint8_t [16]")] public fixed byte PipelineCacheUuid[16];

        public VkPhysicalDeviceLimits Limits;

        public VkPhysicalDeviceSparseProperties SparseProperties;

        
        public utf8string DeviceNameAsUtf8String()
        {
            fixed(sbyte* ptr = DeviceName)
            {
                return new utf8string(ptr);
            }
        }
    }
}
