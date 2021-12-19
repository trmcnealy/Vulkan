using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPhysicalDeviceDisplayProperties2KHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                                 [NativeTypeName("uint32_t *")]           uint*            pPropertyCount,
                                                                                 VkDisplayProperties2KHR*                                  pProperties);
}
