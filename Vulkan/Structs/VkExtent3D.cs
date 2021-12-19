using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExtent3D
    {
        [NativeTypeName("uint32_t")] public uint Width;

        [NativeTypeName("uint32_t")] public uint Height;

        [NativeTypeName("uint32_t")] public uint Depth;

        public VkExtent3D(uint width,
                          uint height,
                          uint depth)
        {
            Width  = width;
            Height = height;
            Depth  = depth;
        }
    }
}
