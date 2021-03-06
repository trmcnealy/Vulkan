using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineRasterizationStateRasterizationOrderAMD
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkRasterizationOrderAMD RasterizationOrder;
    }
}
