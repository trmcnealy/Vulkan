using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkCommandBufferInheritanceViewportScissorInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint pNext;

        [NativeTypeName("VkBool32")] public uint viewportScissor2D;

        [NativeTypeName("uint32_t")] public uint viewportDepthCount;

        [NativeTypeName("const VkViewport *")] public VkViewport* pViewportDepths;
    }
}
