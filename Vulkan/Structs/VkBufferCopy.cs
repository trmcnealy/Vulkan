using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBufferCopy
    {
        [NativeTypeName("VkDeviceSize")]
        public ulong SrcOffset;

        [NativeTypeName("VkDeviceSize")]
        public ulong DstOffset;

        [NativeTypeName("VkDeviceSize")]
        public ulong Size;
    }
}
