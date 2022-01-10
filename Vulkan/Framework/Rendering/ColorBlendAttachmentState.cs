namespace Vulkan.Framework;

public class ColorBlendAttachmentState
{
    public Bool32 BlendEnable = new Bool32(false);

    public VkBlendFactor SrcColorBlendFactor = new VkBlendFactor(VK_BLEND_FACTOR_ONE);

    public VkBlendFactor DstColorBlendFactor = new VkBlendFactor(VK_BLEND_FACTOR_ZERO);

    public VkBlendOp ColorBlendOp = new VkBlendOp(VK_BLEND_OP_ADD);

    public VkBlendFactor SrcAlphaBlendFactor = new VkBlendFactor(VK_BLEND_FACTOR_ONE);

    public VkBlendFactor DstAlphaBlendFactor = new VkBlendFactor(VK_BLEND_FACTOR_ZERO);

    public VkBlendOp AlphaBlendOp = new VkBlendOp(VK_BLEND_OP_ADD);

    public VkColorComponentFlagBits ColorWriteMask = new VkColorComponentFlagBits(VK_COLOR_COMPONENT_R_BIT | VK_COLOR_COMPONENT_G_BIT | VK_COLOR_COMPONENT_B_BIT | VK_COLOR_COMPONENT_A_BIT);
}