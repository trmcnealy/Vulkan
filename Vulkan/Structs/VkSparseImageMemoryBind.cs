using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseImageMemoryBind
    {
        public VkImageSubresource Subresource;

        public VkOffset3D Offset;

        public VkExtent3D Extent;

        [NativeTypeName("VkDeviceMemory")] public VkDeviceMemory Memory;

        [NativeTypeName("VkDeviceSize")] public ulong MemoryOffset;

        [NativeTypeName("VkSparseMemoryBindFlags")]
        public uint Flags;
    }
}
