using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCoarseSampleLocationNV
    {
        [NativeTypeName("uint32_t")] public uint PixelX;

        [NativeTypeName("uint32_t")] public uint PixelY;

        [NativeTypeName("uint32_t")] public uint Sample;
    }
}
