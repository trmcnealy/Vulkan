using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkBindBufferMemoryDeviceGroupInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint DeviceIndexCount;

        [NativeTypeName("const uint32_t *")] public uint* PDeviceIndices;
    }
}
