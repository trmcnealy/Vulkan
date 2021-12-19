using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAttachmentDescriptionStencilLayout
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkImageLayout StencilInitialLayout;

        public VkImageLayout StencilFinalLayout;
    }
}
