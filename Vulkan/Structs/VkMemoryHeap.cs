using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryHeap
    {
        [NativeTypeName("ulong")] public ulong Size;

        [NativeTypeName("VkMemoryHeapFlags")] public uint Flags;
    }
}
