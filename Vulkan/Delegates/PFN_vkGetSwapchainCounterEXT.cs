using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetSwapchainCounterEXT([NativeTypeName("VkDevice")]           VkDevice       device,
                                                                 [NativeTypeName("VkSwapchainKHR")] ref VkSwapchainKHR swapchain,
                                                                 VkSurfaceCounterFlagBitsEXT                           counter,
                                                                 [NativeTypeName("uint64_t *")] ulong*                 pCounterValue);
}
