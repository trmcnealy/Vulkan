using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPastPresentationTimingGOOGLE([NativeTypeName("VkDevice")]           VkDevice       device,
                                                                          [NativeTypeName("VkSwapchainKHR")] ref VkSwapchainKHR swapchain,
                                                                          [NativeTypeName("uint32_t *")]         uint*          pPresentationTimingCount,
                                                                          VkPastPresentationTimingGOOGLE*                       pPresentationTimings);
}
