using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineCacheHeaderVersionOne
    {
        [NativeTypeName("uint32_t")] public uint HeaderSize;

        public VkPipelineCacheHeaderVersion HeaderVersion;

        [NativeTypeName("uint32_t")] public uint VendorId;

        [NativeTypeName("uint32_t")] public uint DeviceId;

        [NativeTypeName("uint8_t [16]")] public fixed byte PipelineCacheUuid[16];
    }
}
