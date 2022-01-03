using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkImageDrmFormatModifierListCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint DrmFormatModifierCount;

        [NativeTypeName("const uint64_t *")] public ulong* PDrmFormatModifiers;
    }
}
