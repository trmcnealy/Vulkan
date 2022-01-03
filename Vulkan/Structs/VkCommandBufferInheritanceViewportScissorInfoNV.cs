using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkCommandBufferInheritanceViewportScissorInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint viewportScissor2D;

        [NativeTypeName("uint32_t")] public uint viewportDepthCount;

        [NativeTypeName("const VkViewport *")] public VkViewport* pViewportDepths;
    }
}
