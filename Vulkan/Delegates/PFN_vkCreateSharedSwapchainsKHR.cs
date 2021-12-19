using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateSharedSwapchainsKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                    [NativeTypeName("uint32_t")] uint     swapchainCount,
                                                                    [NativeTypeName("const VkSwapchainCreateInfoKHR *")]
                                                                    VkSwapchainCreateInfoKHR[] pCreateInfos,
                                                                    [NativeTypeName("const VkAllocationCallbacks *")]
                                                                    in VkAllocationCallbacks pAllocator,
                                                                    [NativeTypeName("VkSwapchainKHR *")] out VkSwapchainKHR pSwapchains);
}
