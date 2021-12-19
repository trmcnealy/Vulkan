using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryRequirements2
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkMemoryRequirements MemoryRequirements;
    }
}