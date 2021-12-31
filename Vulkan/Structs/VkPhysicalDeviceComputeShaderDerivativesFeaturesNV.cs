using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint ComputeDerivativeGroupQuads;

        [NativeTypeName("Bool32")] public uint ComputeDerivativeGroupLinear;
    }
}
