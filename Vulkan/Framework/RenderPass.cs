namespace Vulkan.Framework;

public class RenderPass
{
    private Device _Device;

    private VkRenderPass _Handle = new VkRenderPass(0);

    private nint _SubpassCount = new nint();
}
