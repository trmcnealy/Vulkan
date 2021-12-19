using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint FragmentDensityMap;

        [NativeTypeName("VkBool32")] public uint FragmentDensityMapDynamic;

        [NativeTypeName("VkBool32")] public uint FragmentDensityMapNonSubsampledImages;
    }
}
