using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSemaphoreSubmitInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkSemaphore")] public VkSemaphore Semaphore;

        [NativeTypeName("uint64_t")] public ulong Value;

        [NativeTypeName("VkPipelineStageFlags2KHR")]
        public ulong StageMask;

        [NativeTypeName("uint32_t")] public uint DeviceIndex;
    }
}
