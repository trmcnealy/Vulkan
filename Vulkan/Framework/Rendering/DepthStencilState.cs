namespace Vulkan.Framework;

public class DepthStencilState
{
    public Bool32 DepthTestEnable = new Bool32(true);

    public Bool32 DepthWriteEnable = new Bool32(true);

    // Note: Using Reversed depth-buffer for increased precision, so Greater depth values are kept
    public VkCompareOp DepthCompareOp = new VkCompareOp(VK_COMPARE_OP_GREATER);

    public Bool32 DepthBoundsTestEnable = new Bool32(false);

    public Bool32 StencilTestEnable = new Bool32(false);

    public StencilOpState Front = new StencilOpState();

    public StencilOpState Back = new StencilOpState();
}