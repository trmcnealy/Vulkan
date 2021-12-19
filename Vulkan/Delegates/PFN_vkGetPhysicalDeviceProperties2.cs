using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetPhysicalDeviceProperties2([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                   VkPhysicalDeviceProperties2*                              pProperties);
}
