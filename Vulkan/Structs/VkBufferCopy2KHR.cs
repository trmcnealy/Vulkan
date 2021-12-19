using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBufferCopy2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkDeviceSize")] public ulong SrcOffset;

        [NativeTypeName("VkDeviceSize")] public ulong DstOffset;

        [NativeTypeName("VkDeviceSize")] public ulong Size;
    }
}
