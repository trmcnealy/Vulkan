using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorBufferInfo
    {
        [NativeTypeName("VkBuffer")] public VkBuffer Buffer;

        [NativeTypeName("ulong")] public ulong Offset;

        [NativeTypeName("ulong")] public ulong Range;
    }
}
