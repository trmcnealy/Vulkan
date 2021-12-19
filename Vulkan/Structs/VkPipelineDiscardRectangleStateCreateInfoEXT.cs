using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineDiscardRectangleStateCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkPipelineDiscardRectangleStateCreateFlagsEXT")]
        public uint Flags;

        public VkDiscardRectangleModeEXT DiscardRectangleMode;

        [NativeTypeName("uint32_t")] public uint DiscardRectangleCount;

        [NativeTypeName("const VkRect2D *")] public VkRect2D* PDiscardRectangles;
    }
}
