using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDrmFormatModifierPropertiesListEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint DrmFormatModifierCount;

        public VkDrmFormatModifierPropertiesEXT* PDrmFormatModifierProperties;
    }
}
