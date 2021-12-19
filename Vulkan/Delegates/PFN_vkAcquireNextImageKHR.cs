using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkAcquireNextImageKHR([NativeTypeName("VkDevice")]           VkDevice       device,
                                                              [NativeTypeName("VkSwapchainKHR")] ref VkSwapchainKHR swapchain,
                                                              [NativeTypeName("uint64_t")]           ulong          timeout,
                                                              [NativeTypeName("VkSemaphore")] ref    VkSemaphore    semaphore,
                                                              [NativeTypeName("VkFence")] ref        VkFence        fence,
                                                              [NativeTypeName("uint32_t *")]         uint*          pImageIndex);
}
