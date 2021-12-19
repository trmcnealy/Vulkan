using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPerformanceValueINTEL
    {
        public VkPerformanceValueTypeINTEL Type;

        public VkPerformanceValueDataINTEL Data;
    }
}
