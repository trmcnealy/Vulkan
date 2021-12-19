using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkOffset3D
    {
        [NativeTypeName("int32_t")] public int X;

        [NativeTypeName("int32_t")] public int Y;

        [NativeTypeName("int32_t")] public int Z;
    }
}
