using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        public VkExtent2D MinFragmentDensityTexelSize;

        public VkExtent2D MaxFragmentDensityTexelSize;

        [NativeTypeName("Bool32")] public uint FragmentDensityInvocations;
    }
}
