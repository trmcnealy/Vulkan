namespace Vulkan.Framework
{
//class Device;

/**
 * @brief Description of render pass attachments.
 * Attachment descriptions can be used to automatically create render target images.
 */
public class Attachment
{
    public VkFormat Format = new VkFormat(VK_FORMAT_UNDEFINED);

    public VkSampleCountFlagBits Samples = new VkSampleCountFlagBits(VK_SAMPLE_COUNT_1_BIT);

    public VkImageUsageFlagBits Usage = new VkImageUsageFlagBits(VK_IMAGE_USAGE_SAMPLED_BIT);

    public VkImageLayout InitialLayout = new VkImageLayout(VK_IMAGE_LAYOUT_UNDEFINED);

//    Attachment() = default;

    public Attachment(VkFormat format, VkSampleCountFlagBits samples, VkImageUsageFlagBits usage)
    {
        this.Format = format;
        this.Samples = samples;
        this.Usage = usage;
    }
}
} // namespace vkb


// namespace vkb


namespace Vulkan.Framework
{
    //public partial class GlobalMembers
    //{
    //    public static readonly RenderTarget.CreateFunc RenderTarget.DEFAULT_CREATE_FUNC = (Image && swapchain_image) =>
    //    {
    //        VkFormat     depth_format = GetSuitableDepthFormat(swapchain_image.get_device().get_gpu().get_handle());
    //        Image        depth_image  = new Image(swapchain_image.get_device(), swapchain_image.get_extent(), depth_format, VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT | VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT, VMA_MEMORY_USAGE_GPU_ONLY);
    //        Array<Image> images       = new Array<Image>();
    //        images.Add(std::move(swapchain_image));
    //        images.Add(std::move(depth_image));
    //        return std::make_unique<RenderTarget>(std::move(images));
    //    });
    //}

}