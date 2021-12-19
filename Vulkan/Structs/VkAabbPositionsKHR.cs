using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAabbPositionsKHR
    {
        public float MinX;

        public float MinY;

        public float MinZ;

        public float MaxX;

        public float MaxY;

        public float MaxZ;
    }
}
