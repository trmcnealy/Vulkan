using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint RepresentativeFragmentTest;
    }
}
