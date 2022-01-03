using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkSubpassDescriptionDepthStencilResolve
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkResolveModeFlagBits DepthResolveMode;

        public VkResolveModeFlagBits StencilResolveMode;

        [NativeTypeName("const VkAttachmentReference2 *")]
        public VkAttachmentReference2* PDepthStencilResolveAttachment;
    }
}
