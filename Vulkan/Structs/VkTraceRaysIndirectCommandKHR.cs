using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkTraceRaysIndirectCommandKHR
    {
        [NativeTypeName("uint32_t")] public uint Width;

        [NativeTypeName("uint32_t")] public uint Height;

        [NativeTypeName("uint32_t")] public uint Depth;
    }
}
