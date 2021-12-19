using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    public unsafe struct VkD3D12FenceSubmitInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint WaitSemaphoreValuesCount;

        [NativeTypeName("const uint64_t *")] public ulong* PWaitSemaphoreValues;

        [NativeTypeName("uint32_t")] public uint SignalSemaphoreValuesCount;

        [NativeTypeName("const uint64_t *")] public ulong* PSignalSemaphoreValues;
    }
}
