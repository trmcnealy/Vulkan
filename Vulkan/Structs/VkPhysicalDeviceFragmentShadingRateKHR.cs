using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFragmentShadingRateKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("VkSampleCountFlags")] public uint SampleCounts;

        public VkExtent2D FragmentSize;
    }
}
