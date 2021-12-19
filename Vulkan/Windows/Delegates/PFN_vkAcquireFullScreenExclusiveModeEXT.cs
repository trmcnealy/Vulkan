using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkAcquireFullScreenExclusiveModeEXT([NativeTypeName("VkDevice")]           VkDevice       device,
                                                                     [NativeTypeName("VkSwapchainKHR")] ref VkSwapchainKHR swapchain);
}
