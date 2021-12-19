using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkConformanceVersion
    {
        [NativeTypeName("uint8_t")] public byte Major;

        [NativeTypeName("uint8_t")] public byte Minor;

        [NativeTypeName("uint8_t")] public byte Subminor;

        [NativeTypeName("uint8_t")] public byte Patch;
    }
}
