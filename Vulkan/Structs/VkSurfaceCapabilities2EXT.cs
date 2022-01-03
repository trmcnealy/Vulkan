using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSurfaceCapabilities2EXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint MinImageCount;

        [NativeTypeName("uint32_t")] public uint MaxImageCount;

        public VkExtent2D CurrentExtent;

        public VkExtent2D MinImageExtent;

        public VkExtent2D MaxImageExtent;

        [NativeTypeName("uint32_t")] public uint MaxImageArrayLayers;

        [NativeTypeName("VkSurfaceTransformFlagsKHR")]
        public uint SupportedTransforms;

        public VkSurfaceTransformFlagBitsKHR CurrentTransform;

        [NativeTypeName("VkCompositeAlphaFlagsKHR")]
        public uint SupportedCompositeAlpha;

        [NativeTypeName("VkImageUsageFlags")] public uint SupportedUsageFlags;

        [NativeTypeName("VkSurfaceCounterFlagsEXT")]
        public uint SupportedSurfaceCounters;
    }
}
