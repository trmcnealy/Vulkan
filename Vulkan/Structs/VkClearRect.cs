using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkClearRect
    {
        public VkRect2D Rect;

        [NativeTypeName("uint32_t")] public uint BaseArrayLayer;

        [NativeTypeName("uint32_t")] public uint LayerCount;
    }
}
