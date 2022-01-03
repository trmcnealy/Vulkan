using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDrmFormatModifierPropertiesList2EXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint DrmFormatModifierCount;

        public VkDrmFormatModifierProperties2EXT* PDrmFormatModifierProperties;
    }
}
