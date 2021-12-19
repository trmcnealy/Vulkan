using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkGeometryDataNV
    {
        public VkGeometryTrianglesNV Triangles;

        public VkGeometryAABBNV Aabbs;
    }
}
