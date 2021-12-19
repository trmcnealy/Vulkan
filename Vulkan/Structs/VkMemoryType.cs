using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryType
    {
        [NativeTypeName("VkMemoryPropertyFlags")]
        public VkMemoryPropertyFlagBits PropertyFlags;

        [NativeTypeName("uint32_t")]
        public uint HeapIndex;
    }
}
