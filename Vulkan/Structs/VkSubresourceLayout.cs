using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubresourceLayout
    {
        [NativeTypeName("VkDeviceSize")] public ulong Offset;

        [NativeTypeName("VkDeviceSize")] public ulong Size;

        [NativeTypeName("VkDeviceSize")] public ulong RowPitch;

        [NativeTypeName("VkDeviceSize")] public ulong ArrayPitch;

        [NativeTypeName("VkDeviceSize")] public ulong DepthPitch;
    }
}
