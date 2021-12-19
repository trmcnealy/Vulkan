using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseImageFormatProperties2
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkSparseImageFormatProperties Properties;
    }
}
