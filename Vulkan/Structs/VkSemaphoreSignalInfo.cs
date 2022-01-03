using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSemaphoreSignalInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkSemaphore")] public VkSemaphore Semaphore;

        [NativeTypeName("uint64_t")] public ulong Value;
    }
}
