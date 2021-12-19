using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPhysicalDeviceSurfacePresentModesKHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                                  [NativeTypeName("VkSurfaceKHR")] ref     VkSurfaceKHR     surface,
                                                                                  [NativeTypeName("uint32_t *")]           uint*            pPresentModeCount,
                                                                                  VkPresentModeKHR*                                         pPresentModes);
}
