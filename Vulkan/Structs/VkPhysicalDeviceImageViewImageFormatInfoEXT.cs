using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceImageViewImageFormatInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkImageViewType ImageViewType;
    }
}
