using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    public struct VkMemoryWin32HandlePropertiesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint MemoryTypeBits;
    }
}
