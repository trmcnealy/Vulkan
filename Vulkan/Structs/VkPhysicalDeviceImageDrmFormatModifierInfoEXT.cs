using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("uint64_t")] public ulong DrmFormatModifier;

        public VkSharingMode SharingMode;

        [NativeTypeName("uint32_t")] public uint QueueFamilyIndexCount;

        [NativeTypeName("const uint32_t *")] public uint* PQueueFamilyIndices;
    }
}
