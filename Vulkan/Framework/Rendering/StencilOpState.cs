namespace Vulkan.Framework;

public class StencilOpState
{
    public VkStencilOp FailOp = new VkStencilOp(VK_STENCIL_OP_REPLACE);

    public VkStencilOp PassOp = new VkStencilOp(VK_STENCIL_OP_REPLACE);

    public VkStencilOp DepthFailOp = new VkStencilOp(VK_STENCIL_OP_REPLACE);

    public VkCompareOp CompareOp = new VkCompareOp(VK_COMPARE_OP_NEVER);
}