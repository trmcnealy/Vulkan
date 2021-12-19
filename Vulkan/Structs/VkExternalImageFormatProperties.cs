using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExternalImageFormatProperties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkExternalMemoryProperties ExternalMemoryProperties;
    }
}
