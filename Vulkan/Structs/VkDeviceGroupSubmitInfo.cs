using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDeviceGroupSubmitInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint WaitSemaphoreCount;

        [NativeTypeName("const uint32_t *")] public uint* PWaitSemaphoreDeviceIndices;

        [NativeTypeName("uint32_t")] public uint CommandBufferCount;

        [NativeTypeName("const uint32_t *")] public uint* PCommandBufferDeviceMasks;

        [NativeTypeName("uint32_t")] public uint SignalSemaphoreCount;

        [NativeTypeName("const uint32_t *")] public uint* PSignalSemaphoreDeviceIndices;
    }
}
