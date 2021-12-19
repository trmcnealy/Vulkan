using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkComponentMapping
    {
        public VkComponentSwizzle R;

        public VkComponentSwizzle G;

        public VkComponentSwizzle B;

        public VkComponentSwizzle A;
    }
}
