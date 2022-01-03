using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkRenderPassMultiviewCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint SubpassCount;

        [NativeTypeName("const uint32_t *")] public uint* PViewMasks;

        [NativeTypeName("uint32_t")] public uint DependencyCount;

        [NativeTypeName("const int32_t *")] public int* PViewOffsets;

        [NativeTypeName("uint32_t")] public uint CorrelationMaskCount;

        [NativeTypeName("const uint32_t *")] public uint* PCorrelationMasks;
    }
}
