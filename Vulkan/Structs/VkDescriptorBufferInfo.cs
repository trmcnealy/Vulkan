using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorBufferInfo
    {
        [NativeTypeName("VkBuffer")] public VkBuffer Buffer;

        [NativeTypeName("VkDeviceSize")] public ulong Offset;

        [NativeTypeName("VkDeviceSize")] public ulong Range;
    }
}
