using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkViewport
    {
        public float X;

        public float Y;

        public float Width;

        public float Height;

        public float MinDepth;

        public float MaxDepth;
    }
}
