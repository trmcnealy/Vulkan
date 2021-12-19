using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPhysicalDeviceSurfacePresentModes2EXT([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                                   [NativeTypeName("const VkPhysicalDeviceSurfaceInfo2KHR *")]
                                                                                   VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
                                                                                   [NativeTypeName("uint32_t *")] uint* pPresentModeCount,
                                                                                   VkPresentModeKHR*                    pPresentModes);
}
