using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryRequirements
    {
        [NativeTypeName("VkDeviceSize")] public ulong Size;

        [NativeTypeName("VkDeviceSize")] public ulong Alignment;

        [NativeTypeName("uint32_t")] public uint MemoryTypeBits;
    }
}
