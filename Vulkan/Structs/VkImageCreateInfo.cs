using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkImageCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nuint PNext;

        [NativeTypeName("VkImageCreateFlags")]
        public VkImageCreateFlagBits Flags;

        public VkImageType ImageType;

        public VkFormat Format;

        public VkExtent3D Extent;

        [NativeTypeName("uint32_t")]
        public uint MipLevels;

        [NativeTypeName("uint32_t")]
        public uint ArrayLayers;

        public VkSampleCountFlagBits Samples;

        public VkImageTiling Tiling;

        [NativeTypeName("VkImageUsageFlags")]
        public VkImageUsageFlagBits Usage;

        public VkSharingMode SharingMode;

        [NativeTypeName("uint32_t")]
        public uint QueueFamilyIndexCount;

        [NativeTypeName("const uint32_t *")]
        public uint* PQueueFamilyIndices;

        public VkImageLayout InitialLayout;
    }
}
