using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPhysicalDeviceSurfaceCapabilitiesKHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                                  [NativeTypeName("VkSurfaceKHR")] ref     VkSurfaceKHR     surface,
                                                                                  VkSurfaceCapabilitiesKHR*                                 pSurfaceCapabilities);
}
