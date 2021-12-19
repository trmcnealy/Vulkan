using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDevicePerformanceQueryFeaturesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint PerformanceCounterQueryPools;

        [NativeTypeName("VkBool32")] public uint PerformanceCounterMultipleQueryPools;
    }
}
