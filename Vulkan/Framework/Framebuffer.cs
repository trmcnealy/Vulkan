namespace Vulkan.Framework;

public class Framebuffer
{
    private Device _Device;

    private VkFramebuffer _Handle = new VkFramebuffer(0);

    private VkExtent2D _Extent = new VkExtent2D();
}
