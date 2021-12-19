using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkReleaseFullScreenExclusiveModeEXT([NativeTypeName("VkDevice")]           VkDevice       device,
                                                                     [NativeTypeName("VkSwapchainKHR")] ref VkSwapchainKHR swapchain);
}
