using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBufferCopy
    {
        [NativeTypeName("ulong")]
        public ulong SrcOffset;

        [NativeTypeName("ulong")]
        public ulong DstOffset;

        [NativeTypeName("ulong")]
        public ulong Size;
    }
}
