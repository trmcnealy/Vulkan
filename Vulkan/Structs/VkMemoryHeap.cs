using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryHeap
    {
        [NativeTypeName("VkDeviceSize")] public ulong Size;

        [NativeTypeName("VkMemoryHeapFlags")] public uint Flags;
    }
}
