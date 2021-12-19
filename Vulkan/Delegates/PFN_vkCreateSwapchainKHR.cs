using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateSwapchainKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                             [NativeTypeName("const VkSwapchainCreateInfoKHR *")]
                                                             in VkSwapchainCreateInfoKHR pCreateInfo,
                                                             [NativeTypeName("const VkAllocationCallbacks *")]
                                                             in VkAllocationCallbacks pAllocator,
                                                             [NativeTypeName("VkSwapchainKHR *")] out VkSwapchainKHR pSwapchain);
}
