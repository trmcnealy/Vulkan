namespace Vulkan.Framework;

public class SwapchainProperties
{
    public VkSwapchainKHR                OldSwapchain   = new VkSwapchainKHR();
    public uint                          ImageCount     = new uint(3);
    public VkExtent2D                    Extent         = new VkExtent2D();
    public VkSurfaceFormatKHR            SurfaceFormat  = new VkSurfaceFormatKHR();
    public uint                          ArrayLayers    = new uint();
    public VkImageUsageFlagBits          ImageUsage     = new VkImageUsageFlagBits();
    public VkSurfaceTransformFlagBitsKHR PreTransform   = new VkSurfaceTransformFlagBitsKHR();
    public VkCompositeAlphaFlagBitsKHR   CompositeAlpha = new VkCompositeAlphaFlagBitsKHR();
    public VkPresentModeKHR              PresentMode    = new VkPresentModeKHR();
}
