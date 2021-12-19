using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkViewportSwizzleNV
    {
        public VkViewportCoordinateSwizzleNV X;

        public VkViewportCoordinateSwizzleNV Y;

        public VkViewportCoordinateSwizzleNV Z;

        public VkViewportCoordinateSwizzleNV W;
    }
}
