using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryRequirements
    {
        [NativeTypeName("ulong")] public ulong Size;

        [NativeTypeName("ulong")] public ulong Alignment;

        [NativeTypeName("uint32_t")] public uint MemoryTypeBits;
    }
}
