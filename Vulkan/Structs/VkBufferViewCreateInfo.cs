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

        [NativeTypeName("VkDeviceSize")] public ulong Offset;

        [NativeTypeName("VkDeviceSize")] public ulong Range;
    }
}
