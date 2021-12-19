using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkTimelineSemaphoreSubmitInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint WaitSemaphoreValueCount;

        [NativeTypeName("const uint64_t *")] public ulong* PWaitSemaphoreValues;

        [NativeTypeName("uint32_t")] public uint SignalSemaphoreValueCount;

        [NativeTypeName("const uint64_t *")] public ulong* PSignalSemaphoreValues;
    }
}
