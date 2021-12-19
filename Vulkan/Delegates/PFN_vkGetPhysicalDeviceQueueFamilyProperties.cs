using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetPhysicalDeviceQueueFamilyProperties([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                             [NativeTypeName("uint32_t *")]           uint*            pQueueFamilyPropertyCount,
                                                                             VkQueueFamilyProperties*                                  pQueueFamilyProperties);
}
