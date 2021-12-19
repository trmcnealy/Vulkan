using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExternalBufferProperties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkExternalMemoryProperties ExternalMemoryProperties;
    }
}
