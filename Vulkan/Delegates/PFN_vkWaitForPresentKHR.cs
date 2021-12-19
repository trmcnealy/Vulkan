using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkWaitForPresentKHR([NativeTypeName("VkDevice")]           VkDevice       device,
                                                     [NativeTypeName("VkSwapchainKHR")] ref VkSwapchainKHR swapchain,
                                                     [NativeTypeName("uint64_t")]           ulong          presentId,
                                                     [NativeTypeName("uint64_t")]           ulong          timeout);
}
