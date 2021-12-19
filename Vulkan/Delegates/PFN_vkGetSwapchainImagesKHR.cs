using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetSwapchainImagesKHR([NativeTypeName("VkDevice")]           VkDevice       device,
                                                                [NativeTypeName("VkSwapchainKHR")] ref VkSwapchainKHR swapchain,
                                                                [NativeTypeName("uint32_t *")]         uint*          pSwapchainImageCount,
                                                                [NativeTypeName("VkImage *")] ref      VkImage*       pSwapchainImages);
}
