using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayPlaneCapabilitiesKHR
    {
        [NativeTypeName("VkDisplayPlaneAlphaFlagsKHR")]
        public uint SupportedAlpha;

        public VkOffset2D MinSrcPosition;

        public VkOffset2D MaxSrcPosition;

        public VkExtent2D MinSrcExtent;

        public VkExtent2D MaxSrcExtent;

        public VkOffset2D MinDstPosition;

        public VkOffset2D MaxDstPosition;

        public VkExtent2D MinDstExtent;

        public VkExtent2D MaxDstExtent;
    }
}
