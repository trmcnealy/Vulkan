using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPhysicalDeviceSurfaceFormats2KHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                              [NativeTypeName("const VkPhysicalDeviceSurfaceInfo2KHR *")]
                                                                              in VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo,
                                                                              [NativeTypeName("uint32_t *")] in uint pSurfaceFormatCount,
                                                                              VkSurfaceFormat2KHR*                 pSurfaceFormats);
}
