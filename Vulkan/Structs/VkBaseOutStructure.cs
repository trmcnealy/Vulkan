using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkBaseOutStructure
    {
        public VkStructureType SType;

        [NativeTypeName("struct VkBaseOutStructure *")]
        public VkBaseOutStructure* PNext;
    }
}
