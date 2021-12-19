using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseImageMemoryRequirements2
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkSparseImageMemoryRequirements MemoryRequirements;
    }
}
