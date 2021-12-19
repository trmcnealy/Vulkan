using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkSetLocalDimmingAMD([NativeTypeName("VkDevice")]           VkDevice       device,
                                                  [NativeTypeName("VkSwapchainKHR")] ref VkSwapchainKHR swapChain,
                                                  [NativeTypeName("VkBool32")]           uint           localDimmingEnable);
}
