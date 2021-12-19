using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShadingRateImageFeaturesNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint ShadingRateImage;

        [NativeTypeName("VkBool32")] public uint ShadingRateCoarseSampleOrder;
    }
}
