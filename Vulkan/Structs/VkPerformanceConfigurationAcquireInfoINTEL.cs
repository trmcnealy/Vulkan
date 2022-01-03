using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPerformanceConfigurationAcquireInfoINTEL
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkPerformanceConfigurationTypeINTEL Type;
    }
}
