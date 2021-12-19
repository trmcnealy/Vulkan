using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageViewHandleInfoNVX
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkImageView")] public VkImageView ImageView;

        public VkDescriptorType DescriptorType;

        [NativeTypeName("VkSampler")] public VkSampler Sampler;
    }
}
