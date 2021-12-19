using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExtent2D
    {
        [NativeTypeName("uint32_t")]
        public uint Width;

        [NativeTypeName("uint32_t")]
        public uint Height;

        public VkExtent2D(uint width, uint height)
        {
            Width = width;
            Height = height;
        }
    }
}
