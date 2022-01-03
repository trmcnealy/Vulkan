using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAttachmentDescriptionStencilLayout
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        public VkImageLayout StencilInitialLayout;

        public VkImageLayout StencilFinalLayout;
    }
}
