using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPhysicalDeviceSampleLocationsPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkSampleCountFlags")] public uint SampleLocationSampleCounts;

        public VkExtent2D MaxSampleLocationGridSize;

        [NativeTypeName("float [2]")] public fixed float SampleLocationCoordinateRange[2];

        [NativeTypeName("uint32_t")] public uint SampleLocationSubPixelBits;

        [NativeTypeName("Bool32")] public uint VariableSampleLocations;
    }
}
