using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShadingRateImagePropertiesNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        public VkExtent2D ShadingRateTexelSize;

        [NativeTypeName("uint32_t")] public uint ShadingRatePaletteSize;

        [NativeTypeName("uint32_t")] public uint ShadingRateMaxCoarseSamples;
    }
}
