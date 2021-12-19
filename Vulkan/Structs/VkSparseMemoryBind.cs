using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseMemoryBind
    {
        [NativeTypeName("VkDeviceSize")] public ulong ResourceOffset;

        [NativeTypeName("VkDeviceSize")] public ulong Size;

        [NativeTypeName("VkDeviceMemory")] public VkDeviceMemory Memory;

        [NativeTypeName("VkDeviceSize")] public ulong MemoryOffset;

        [NativeTypeName("VkSparseMemoryBindFlags")]
        public uint Flags;
    }
}
