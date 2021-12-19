using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPhysicalDeviceDisplayPlaneProperties2KHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                                      [NativeTypeName("uint32_t *")]           uint*            pPropertyCount,
                                                                                      VkDisplayPlaneProperties2KHR*                             pProperties);
}
