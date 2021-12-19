using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRectLayerKHR
    {
        public VkOffset2D Offset;

        public VkExtent2D Extent;

        [NativeTypeName("uint32_t")] public uint Layer;
    }
}
