using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBindIndexBufferIndirectCommandNV
    {
        [NativeTypeName("VkDeviceAddress")] public ulong BufferAddress;

        [NativeTypeName("uint32_t")] public uint Size;

        public VkIndexType IndexType;
    }
}
