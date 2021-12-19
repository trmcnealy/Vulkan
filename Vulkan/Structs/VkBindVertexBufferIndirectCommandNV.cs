using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBindVertexBufferIndirectCommandNV
    {
        [NativeTypeName("VkDeviceAddress")] public ulong BufferAddress;

        [NativeTypeName("uint32_t")] public uint Size;

        [NativeTypeName("uint32_t")] public uint Stride;
    }
}
