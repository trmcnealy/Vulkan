using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFragmentShadingRateFeaturesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint PipelineFragmentShadingRate;

        [NativeTypeName("VkBool32")] public uint PrimitiveFragmentShadingRate;

        [NativeTypeName("VkBool32")] public uint AttachmentFragmentShadingRate;
    }
}
