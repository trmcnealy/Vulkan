using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSurfaceCapabilitiesKHR
    {
        [NativeTypeName("uint32_t")] public uint MinImageCount;

        [NativeTypeName("uint32_t")] public uint MaxImageCount;

        public VkExtent2D CurrentExtent;

        public VkExtent2D MinImageExtent;

        public VkExtent2D MaxImageExtent;

        [NativeTypeName("uint32_t")] public uint MaxImageArrayLayers;

        [NativeTypeName("VkSurfaceTransformFlagsKHR")]
        public VkSurfaceTransformFlagBitsKHR SupportedTransforms;

        public VkSurfaceTransformFlagBitsKHR CurrentTransform;

        [NativeTypeName("VkCompositeAlphaFlagsKHR")]
        public VkCompositeAlphaFlagBitsKHR SupportedCompositeAlpha;

        [NativeTypeName("VkImageUsageFlags")] public uint SupportedUsageFlags;
    }
}
