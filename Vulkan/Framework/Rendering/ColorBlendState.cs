namespace Vulkan.Framework;

public class ColorBlendState
{
    public Bool32 LogicOpEnable = new Bool32(false);

    public VkLogicOp LogicOp = new VkLogicOp(VK_LOGIC_OP_CLEAR);

    public Array<ColorBlendAttachmentState> Attachments = new Array<ColorBlendAttachmentState>();
}