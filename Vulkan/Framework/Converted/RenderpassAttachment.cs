namespace Vulkan.Framework;

public sealed class RenderpassAttachment
{
    public static readonly RenderpassAttachment Null = new();

    public  VkImageLayout            ref_layout { get; set; }
    public  RenderpassAttachmentType type       { get; set; }
    private VkFormat                 format     { get; set; }
    public  VkImageLayout            src_layout { get; set; }
    public  VkImageLayout            dst_layout { get; set; }
    public  VkAttachmentLoadOp       load_op    { get; set; }
    public  VkAttachmentStoreOp      store_op   { get; set; }

    private RenderpassAttachment()
    {
    }

    public RenderpassAttachment(VkImageLayout            refLayout,
                                RenderpassAttachmentType type,
                                VkFormat                 format,
                                VkImageLayout            srcLayout,
                                VkImageLayout            dstLayout,
                                VkAttachmentLoadOp       loadOp,
                                VkAttachmentStoreOp      storeOp)
    {
        ref_layout  = refLayout;
        this.type   = type;
        this.format = format;
        src_layout  = srcLayout;
        dst_layout  = dstLayout;
        load_op     = loadOp;
        store_op    = storeOp;
    }
}
