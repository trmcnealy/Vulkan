using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAttachmentReferenceStencilLayout
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        public VkImageLayout StencilLayout;
    }
}
