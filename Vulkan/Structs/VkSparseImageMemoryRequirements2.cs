using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseImageMemoryRequirements2
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        public VkSparseImageMemoryRequirements MemoryRequirements;
    }
}
