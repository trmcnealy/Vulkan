using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkIndirectCommandsStreamNV
    {
        [NativeTypeName("VkBuffer")] public VkBuffer Buffer;

        [NativeTypeName("VkDeviceSize")] public ulong Offset;
    }
}
