using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAcquireProfilingLockInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkAcquireProfilingLockFlagsKHR")]
        public uint Flags;

        [NativeTypeName("uint64_t")] public ulong Timeout;
    }
}
