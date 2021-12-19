using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint FragmentShaderSampleInterlock;

        [NativeTypeName("VkBool32")] public uint FragmentShaderPixelInterlock;

        [NativeTypeName("VkBool32")] public uint FragmentShaderShadingRateInterlock;
    }
}
