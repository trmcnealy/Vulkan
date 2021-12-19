using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkBaseInStructure
    {
        public VkStructureType SType;

        [NativeTypeName("const struct VkBaseInStructure *")]
        public VkBaseInStructure* PNext;
    }
}
