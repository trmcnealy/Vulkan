using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint AcquireCount;

        [NativeTypeName("const VkDeviceMemory *")]
        public VkDeviceMemory* PAcquireSyncs;

        [NativeTypeName("const uint64_t *")] public ulong* PAcquireKeys;

        [NativeTypeName("const uint32_t *")] public uint* PAcquireTimeoutMilliseconds;

        [NativeTypeName("uint32_t")] public uint ReleaseCount;

        [NativeTypeName("const VkDeviceMemory *")]
        public VkDeviceMemory* PReleaseSyncs;

        [NativeTypeName("const uint64_t *")] public ulong* PReleaseKeys;
    }
}
