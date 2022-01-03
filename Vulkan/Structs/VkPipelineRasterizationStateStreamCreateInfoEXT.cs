using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineRasterizationStateStreamCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkPipelineRasterizationStateStreamCreateFlagsEXT")]
        public uint Flags;

        [NativeTypeName("uint32_t")] public uint RasterizationStream;
    }
}
