using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPhysicalDeviceSurfaceSupportKHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                             [NativeTypeName("uint32_t")]             uint             queueFamilyIndex,
                                                                             [NativeTypeName("VkSurfaceKHR")] ref     VkSurfaceKHR     surface,
                                                                             [NativeTypeName("VkBool32 *")]           uint*            pSupported);
}
