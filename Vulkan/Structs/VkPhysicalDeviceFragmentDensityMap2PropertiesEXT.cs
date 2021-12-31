using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint SubsampledLoads;

        [NativeTypeName("Bool32")] public uint SubsampledCoarseReconstructionEarlyAccess;

        [NativeTypeName("uint32_t")] public uint MaxSubsampledArrayLayers;

        [NativeTypeName("uint32_t")] public uint MaxDescriptorSetSubsampledSamplers;
    }
}
