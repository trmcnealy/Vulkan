namespace Vulkan.Framework;

public sealed class RenderpassDependency
{
    public static readonly RenderpassDependency Null = new();

    public uint                    src_subpass { get; set; }
    public VkPipelineStageFlagBits src_stage   { get; set; }
    public VkAccessFlagBits        src_access  { get; set; }
    public uint                    dst_subpass { get; set; }
    public VkPipelineStageFlagBits dst_stage   { get; set; }
    public VkAccessFlagBits        dst_access  { get; set; }
    
    private RenderpassDependency()
    {
    }

    public RenderpassDependency(uint                    srcSubpass,
                                VkPipelineStageFlagBits srcStage,
                                VkAccessFlagBits        srcAccess,
                                uint                    dstSubpass,
                                VkPipelineStageFlagBits dstStage,
                                VkAccessFlagBits        dstAccess)
    {
        src_subpass = srcSubpass;
        src_stage   = srcStage;
        src_access  = srcAccess;
        dst_subpass = dstSubpass;
        dst_stage   = dstStage;
        dst_access  = dstAccess;
    }
}