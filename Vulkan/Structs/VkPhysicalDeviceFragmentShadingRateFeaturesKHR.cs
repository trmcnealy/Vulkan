using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFragmentShadingRateFeaturesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint PipelineFragmentShadingRate;

        [NativeTypeName("Bool32")] public uint PrimitiveFragmentShadingRate;

        [NativeTypeName("Bool32")] public uint AttachmentFragmentShadingRate;
    }
}
