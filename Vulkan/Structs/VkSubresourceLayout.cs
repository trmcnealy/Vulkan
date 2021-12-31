using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubresourceLayout
    {
        [NativeTypeName("ulong")] public ulong Offset;

        [NativeTypeName("ulong")] public ulong Size;

        [NativeTypeName("ulong")] public ulong RowPitch;

        [NativeTypeName("ulong")] public ulong ArrayPitch;

        [NativeTypeName("ulong")] public ulong DepthPitch;
    }
}
