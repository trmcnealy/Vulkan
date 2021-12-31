using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryAllocateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("ulong")] public ulong AllocationSize;

        [NativeTypeName("uint32_t")] public uint MemoryTypeIndex;
    }
}
