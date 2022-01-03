using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBufferCopy2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("ulong")] public ulong SrcOffset;

        [NativeTypeName("ulong")] public ulong DstOffset;

        [NativeTypeName("ulong")] public ulong Size;
    }
}
