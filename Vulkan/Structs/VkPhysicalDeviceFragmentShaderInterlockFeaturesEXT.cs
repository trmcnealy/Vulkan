using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint FragmentShaderSampleInterlock;

        [NativeTypeName("Bool32")] public uint FragmentShaderPixelInterlock;

        [NativeTypeName("Bool32")] public uint FragmentShaderShadingRateInterlock;
    }
}
