using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryAllocateFlagsInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkMemoryAllocateFlags")]
        public uint Flags;

        [NativeTypeName("uint32_t")] public uint DeviceMask;
    }
}
