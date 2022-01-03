using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint RequiredSubgroupSize;
    }
}
