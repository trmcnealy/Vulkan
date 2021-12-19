using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPhysicalDeviceSurfaceCapabilities2KHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                                   [NativeTypeName("const VkPhysicalDeviceSurfaceInfo2KHR *")]
                                                                                   in VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo,
                                                                                   VkSurfaceCapabilities2KHR[] pSurfaceCapabilities);
}
