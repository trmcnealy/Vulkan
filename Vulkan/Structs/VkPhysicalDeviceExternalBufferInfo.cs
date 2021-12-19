using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceExternalBufferInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkBufferCreateFlags")]
        public uint Flags;

        [NativeTypeName("VkBufferUsageFlags")] public uint Usage;

        public VkExternalMemoryHandleTypeFlagBits HandleType;
    }
}
