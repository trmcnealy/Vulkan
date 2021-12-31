using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseMemoryBind
    {
        [NativeTypeName("ulong")] public ulong ResourceOffset;

        [NativeTypeName("ulong")] public ulong Size;

        [NativeTypeName("VkDeviceMemory")] public VkDeviceMemory Memory;

        [NativeTypeName("ulong")] public ulong MemoryOffset;

        [NativeTypeName("VkSparseMemoryBindFlags")]
        public uint Flags;
    }
}
