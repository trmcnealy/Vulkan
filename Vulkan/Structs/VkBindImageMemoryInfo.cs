using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBindImageMemoryInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkImage")] public VkImage Image;

        [NativeTypeName("VkDeviceMemory")] public VkDeviceMemory Memory;

        [NativeTypeName("ulong")] public ulong MemoryOffset;
    }
}
