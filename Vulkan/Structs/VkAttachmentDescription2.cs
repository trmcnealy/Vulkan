using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAttachmentDescription2
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkAttachmentDescriptionFlags")]
        public uint Flags;

        public VkFormat Format;

        public VkSampleCountFlagBits Samples;

        public VkAttachmentLoadOp LoadOp;

        public VkAttachmentStoreOp StoreOp;

        public VkAttachmentLoadOp StencilLoadOp;

        public VkAttachmentStoreOp StencilStoreOp;

        public VkImageLayout InitialLayout;

        public VkImageLayout FinalLayout;
    }
}
