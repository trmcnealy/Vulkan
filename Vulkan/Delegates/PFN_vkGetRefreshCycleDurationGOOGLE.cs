using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetRefreshCycleDurationGOOGLE([NativeTypeName("VkDevice")]           VkDevice       device,
                                                                        [NativeTypeName("VkSwapchainKHR")] ref VkSwapchainKHR swapchain,
                                                                        VkRefreshCycleDurationGOOGLE*                         pDisplayTimingProperties);
}
