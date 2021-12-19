using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPhysicalDeviceSurfaceCapabilities2EXT([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                                   [NativeTypeName("VkSurfaceKHR")] ref     VkSurfaceKHR     surface,
                                                                                   VkSurfaceCapabilities2EXT*                                pSurfaceCapabilities);
}
