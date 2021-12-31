using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint FragmentDensityMap;

        [NativeTypeName("Bool32")] public uint FragmentDensityMapDynamic;

        [NativeTypeName("Bool32")] public uint FragmentDensityMapNonSubsampledImages;
    }
}
