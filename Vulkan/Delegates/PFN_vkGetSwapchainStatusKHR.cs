using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkGetSwapchainStatusKHR([NativeTypeName("VkDevice")]           VkDevice       device,
                                                         [NativeTypeName("VkSwapchainKHR")] ref VkSwapchainKHR swapchain);
}
