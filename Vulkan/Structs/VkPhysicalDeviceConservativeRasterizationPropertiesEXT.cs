using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public float PrimitiveOverestimationSize;

        public float MaxExtraPrimitiveOverestimationSize;

        public float ExtraPrimitiveOverestimationSizeGranularity;

        [NativeTypeName("VkBool32")] public uint PrimitiveUnderestimation;

        [NativeTypeName("VkBool32")] public uint ConservativePointAndLineRasterization;

        [NativeTypeName("VkBool32")] public uint DegenerateTrianglesRasterized;

        [NativeTypeName("VkBool32")] public uint DegenerateLinesRasterized;

        [NativeTypeName("VkBool32")] public uint FullyCoveredFragmentShaderInputVariable;

        [NativeTypeName("VkBool32")] public uint ConservativeRasterizationPostDepthCoverage;
    }
}
