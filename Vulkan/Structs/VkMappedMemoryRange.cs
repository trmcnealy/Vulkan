using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMappedMemoryRange
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkDeviceMemory")] public VkDeviceMemory Memory;

        [NativeTypeName("ulong")] public ulong Offset;

        [NativeTypeName("ulong")] public ulong Size;
    }
}
