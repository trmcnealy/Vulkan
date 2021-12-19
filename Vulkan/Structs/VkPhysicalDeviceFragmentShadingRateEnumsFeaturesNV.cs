using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint FragmentShadingRateEnums;

        [NativeTypeName("VkBool32")] public uint SupersampleFragmentShadingRates;

        [NativeTypeName("VkBool32")] public uint NoInvocationFragmentShadingRates;
    }
}
