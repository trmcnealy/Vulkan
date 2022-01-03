using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint FragmentShadingRateEnums;

        [NativeTypeName("Bool32")] public uint SupersampleFragmentShadingRates;

        [NativeTypeName("Bool32")] public uint NoInvocationFragmentShadingRates;
    }
}
