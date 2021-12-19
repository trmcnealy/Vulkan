using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkCoarseSampleOrderCustomNV
    {
        public VkShadingRatePaletteEntryNV ShadingRate;

        [NativeTypeName("uint32_t")] public uint SampleCount;

        [NativeTypeName("uint32_t")] public uint SampleLocationCount;

        [NativeTypeName("const VkCoarseSampleLocationNV *")]
        public VkCoarseSampleLocationNV* PSampleLocations;
    }
}
