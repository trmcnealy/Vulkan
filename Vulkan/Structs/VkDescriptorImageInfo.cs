using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorImageInfo
    {
        [NativeTypeName("VkSampler")] public VkSampler Sampler;

        [NativeTypeName("VkImageView")] public VkImageView ImageView;

        public VkImageLayout ImageLayout;
    }
}
