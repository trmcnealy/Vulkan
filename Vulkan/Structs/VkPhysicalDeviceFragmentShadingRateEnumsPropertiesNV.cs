using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkSampleCountFlagBits MaxFragmentShadingRateInvocationCount;
    }
}
