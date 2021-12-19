using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineRasterizationConservativeStateCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkPipelineRasterizationConservativeStateCreateFlagsEXT")]
        public uint Flags;

        public VkConservativeRasterizationModeEXT ConservativeRasterizationMode;

        public float ExtraPrimitiveOverestimationSize;
    }
}
