namespace Vulkan.Framework;

public class RasterizationState
{
    public Bool32 DepthClampEnable = new Bool32(false);

    public Bool32 RasterizerDiscardEnable = new Bool32(false);

    public VkPolygonMode PolygonMode = new VkPolygonMode(VK_POLYGON_MODE_FILL);

    public VkCullModeFlagBits CullMode = new VkCullModeFlagBits(VK_CULL_MODE_BACK_BIT);

    public VkFrontFace FrontFace = new VkFrontFace(VK_FRONT_FACE_COUNTER_CLOCKWISE);

    public Bool32 DepthBiasEnable = new Bool32(false);
}