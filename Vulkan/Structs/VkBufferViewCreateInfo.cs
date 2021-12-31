using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBufferViewCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkBufferViewCreateFlags")]
        public uint Flags;

        [NativeTypeName("VkBuffer")] public VkBuffer Buffer;

        public VkFormat Format;

        [NativeTypeName("ulong")] public ulong Offset;

        [NativeTypeName("ulong")] public ulong Range;
    }
}
