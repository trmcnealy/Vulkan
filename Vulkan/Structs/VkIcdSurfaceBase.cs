using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkIcdSurfaceBase
    {
        public VkIcdWsiPlatform Platform;
    }
}
