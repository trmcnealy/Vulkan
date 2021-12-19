using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkOffset2D
    {
        [NativeTypeName("int32_t")]
        public int X;

        [NativeTypeName("int32_t")]
        public int Y;

        public VkOffset2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
