using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShadingRateImageFeaturesNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint ShadingRateImage;

        [NativeTypeName("Bool32")] public uint ShadingRateCoarseSampleOrder;
    }
}
