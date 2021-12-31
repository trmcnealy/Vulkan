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

        [NativeTypeName("Bool32")] public uint PrimitiveUnderestimation;

        [NativeTypeName("Bool32")] public uint ConservativePointAndLineRasterization;

        [NativeTypeName("Bool32")] public uint DegenerateTrianglesRasterized;

        [NativeTypeName("Bool32")] public uint DegenerateLinesRasterized;

        [NativeTypeName("Bool32")] public uint FullyCoveredFragmentShaderInputVariable;

        [NativeTypeName("Bool32")] public uint ConservativeRasterizationPostDepthCoverage;
    }
}
