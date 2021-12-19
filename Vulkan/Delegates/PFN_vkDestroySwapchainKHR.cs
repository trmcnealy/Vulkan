using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroySwapchainKHR([NativeTypeName("VkDevice")]           VkDevice       device,
                                                          [NativeTypeName("VkSwapchainKHR")] ref VkSwapchainKHR swapchain,
                                                          [NativeTypeName("const VkAllocationCallbacks *")]
                                                          in VkAllocationCallbacks pAllocator);
}
