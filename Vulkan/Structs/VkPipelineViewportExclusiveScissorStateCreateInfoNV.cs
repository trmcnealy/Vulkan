using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineViewportExclusiveScissorStateCreateInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint ExclusiveScissorCount;

        [NativeTypeName("const VkRect2D *")] public VkRect2D* PExclusiveScissors;
    }
}
