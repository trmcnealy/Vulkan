using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkQueryPoolPerformanceQueryCreateInfoINTEL
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkQueryPoolSamplingModeINTEL PerformanceCountersSampling;
    }
}
