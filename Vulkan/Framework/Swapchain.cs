using System.Collections.Generic;

namespace Vulkan.Framework;

public class Swapchain
{
    private Device _Device;

    private VkSurfaceKHR _Surface = new VkSurfaceKHR(0);

    private VkSwapchainKHR _Handle = new VkSwapchainKHR(0);

    private Array<VkImage> _Images = new Array<VkImage>();

    private Array<VkSurfaceFormatKHR> _SurfaceFormats = new Array<VkSurfaceFormatKHR>();

    private Array<VkPresentModeKHR> _PresentModes = new Array<VkPresentModeKHR>();

    private SwapchainProperties _Properties = new SwapchainProperties();

    // A list of present modes in order of priority (vector[0] has high priority, vector[size-1] has low priority)
    private Array<VkPresentModeKHR> _PresentModePriorityList = new Array<VkPresentModeKHR>()
    {
        VK_PRESENT_MODE_FIFO_KHR,
        VK_PRESENT_MODE_MAILBOX_KHR
    };

    // A list of surface formats in order of priority (vector[0] has high priority, vector[size-1] has low priority)
    private Array<VkSurfaceFormatKHR> _SurfaceFormatPriorityList = new Array<VkSurfaceFormatKHR>()
    {
        {
            VK_FORMAT_R8G8B8A8_SRGB, VK_COLOR_SPACE_SRGB_NONLINEAR_KHR
        },
        {
            VK_FORMAT_B8G8R8A8_SRGB, VK_COLOR_SPACE_SRGB_NONLINEAR_KHR
        },
        {
            VK_FORMAT_R8G8B8A8_UNORM, VK_COLOR_SPACE_SRGB_NONLINEAR_KHR
        },
        {
            VK_FORMAT_B8G8R8A8_UNORM, VK_COLOR_SPACE_SRGB_NONLINEAR_KHR
        }
    };

    private SortedSet<VkImageUsageFlagBits> _ImageUsageFlagBits = new SortedSet<VkImageUsageFlagBits>();
}
