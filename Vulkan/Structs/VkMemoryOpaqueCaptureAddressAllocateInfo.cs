using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryOpaqueCaptureAddressAllocateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("uint64_t")] public ulong OpaqueCaptureAddress;
    }
}
