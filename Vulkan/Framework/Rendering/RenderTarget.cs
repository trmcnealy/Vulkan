using System.Diagnostics;

namespace Vulkan.Framework;

/**
 * @brief RenderTarget contains three vectors for: core::Image, core::ImageView and Attachment.
 * The first two are Vulkan images and corresponding image views respectively.
 * Attachment (s) contain a description of the images, which has two main purposes:
 * - RenderPass creation only needs a Array of Attachment (s), not the actual images, so we keep
 *   the minimum amount of information necessary
 * - Creation of a RenderTarget becomes simpler, because the caller can just ask for some
 *   Attachment (s) without having to create the images
 */
public class RenderTarget
{
    public delegate std::unique_ptr<RenderTarget> CreateFunc(Image &&);

    public const CreateFunc DEFAULT_CREATE_FUNC;

    public RenderTarget(Array<Image> &&images)
    {
        this._Device = new Device(_Images[_Images.Count - 1].GetDevice());
        this._Images = std::move(_Images);
        Debug.Assert(this._Images.Count > 0 && "Should specify at least 1 image");

        SortedSet<VkExtent2D, CompareExtent2D> unique_extent = new SortedSet<VkExtent2D, CompareExtent2D>();

        // Returns the image extent as a VkExtent2D structure from a VkExtent3D
        var get_image_extent = (Image image) =>
        {
            return VkExtent2D{image.GetExtent().width, image.GetExtent().height};
        };

        // Constructs a set of unique image extens given a vector of images
        std::transform(this._Images.GetEnumerator(), this._Images.end(), std::inserter(unique_extent, unique_extent.end()), get_image_extent);

        // Allow only one extent size for a render target
        if (unique_extent.Count != 1)
        {
            throw new VulkanException(new VkResult(VK_ERROR_INITIALIZATION_FAILED, "Extent size is not unique"));
        }

        _Extent = *unique_extent.GetEnumerator();

        foreach (var image in this._Images)
        {
            if (image.GetType() != VK_IMAGE_TYPE_2D)
            {
                throw new VulkanException(new VkResult(VK_ERROR_INITIALIZATION_FAILED, "Image type is not 2D"));
            }

            _Views.emplace_back(image, VK_IMAGE_VIEW_TYPE_2D);

            _Attachments.emplace_back(new Attachment({image.GetFormat(), image.GetSampleCount(), image.GetUsage()}));
        }
    }

    public RenderTarget(Array<ImageView> &&image_views)
    {
        this._Device = new Device(const_cast <Image & >(image_views.back().get_image()).get_device());
        this._Images = new Array<Image>();
        this._Views  = std::move(image_views);
        Debug.Assert(_Views.Count > 0 && "Should specify at least 1 image view");

        SortedSet<VkExtent2D, CompareExtent2D> unique_extent = new SortedSet<VkExtent2D, CompareExtent2D>();

        // Returns the extent of the base mip level pointed at by a view
        var get_view_extent = (ImageView view) =>
        {
            VkExtent3D mip0_extent = view.GetImage().GetExtent();
            uint       mip_level   = view.GetSubresourceRange().baseMipLevel;
            return VkExtent2D{mip0_extent.width >> mip_level, mip0_extent.height >> mip_level};
        };

        // Constructs a set of unique image extents given a vector of image views;
        // allow only one extent size for a render target
        std::transform(_Views.GetEnumerator(), _Views.end(), std::inserter(unique_extent, unique_extent.end()), get_view_extent);
        if (unique_extent.Count != 1)
        {
            throw new VulkanException(new VkResult(VK_ERROR_INITIALIZATION_FAILED, "Extent size is not unique"));
        }
        _Extent = *unique_extent.GetEnumerator();

        foreach (var view in _Views)
        {
            in auto image = view.GetImage();
            _Attachments.emplace_back(new Attachment({image.get_format(), image.get_sample_count(), image.get_usage()}));
        }
    }

//    RenderTarget(@in RenderTarget) = delete;

//    RenderTarget(RenderTarget &&) = delete;

//    RenderTarget &operator =(@in RenderTarget other) noexcept = delete;

//    RenderTarget &operator =(RenderTarget &&other) noexcept = delete;

    public VkExtent2D GetExtent()
    {
        return _Extent;
    }

    public Array<ImageView> GetViews()
    {
        return _Views;
    }

    public Array<Attachment> GetAttachments()
    {
        return _Attachments;
    }

    /**
     * @brief Sets the current input attachments overwriting the current ones
     *        Should be set before beginning the render pass and before starting a new subpass
     * @param input Set of attachment reference number to use as input
     */
    public void SetInputAttachments(Array<uint> input)
    {
        _InputAttachments = input;
    }

    public Array<uint> GetInputAttachments()
    {
        return _InputAttachments;
    }

    /**
     * @brief Sets the current output attachments overwriting the current ones
     *        Should be set before beginning the render pass and before starting a new subpass
     * @param output Set of attachment reference number to use as output
     */
    public void SetOutputAttachments(Array<uint> output)
    {
        _OutputAttachments = output;
    }

    public Array<uint> GetOutputAttachments()
    {
        return _OutputAttachments;
    }

    public void SetLayout(uint attachment, VkImageLayout layout)
    {
        _Attachments[attachment].InitialLayout = layout;
    }

    public VkImageLayout GetLayout(uint attachment)
    {
        return _Attachments[attachment].InitialLayout;
    }

    private Device _Device;

    private VkExtent2D _Extent = new VkExtent2D();

    private Array<Image> _Images = new Array<Image>();

    private Array<ImageView> _Views = new Array<ImageView>();

    private Array<Attachment> _Attachments = new Array<Attachment>();

    /// By default there are no input attachments
    private Array<uint> _InputAttachments = new Array<uint>();

    /// By default the output attachments is attachment 0
    private Array<uint> _OutputAttachments = new Array<uint>() {0};
}