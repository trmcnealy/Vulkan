using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkFragmentShadingRateAttachmentInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("const VkAttachmentReference2 *")]
        public VkAttachmentReference2* PFragmentShadingRateAttachment;

        public VkExtent2D ShadingRateAttachmentTexelSize;
    }
}
