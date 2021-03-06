using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBufferMemoryBarrier
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkAccessFlags")] public uint SrcAccessMask;

        [NativeTypeName("VkAccessFlags")] public uint DstAccessMask;

        [NativeTypeName("uint32_t")] public uint SrcQueueFamilyIndex;

        [NativeTypeName("uint32_t")] public uint DstQueueFamilyIndex;

        [NativeTypeName("VkBuffer")] public VkBuffer Buffer;

        [NativeTypeName("ulong")] public ulong Offset;

        [NativeTypeName("ulong")] public ulong Size;
    }
}
