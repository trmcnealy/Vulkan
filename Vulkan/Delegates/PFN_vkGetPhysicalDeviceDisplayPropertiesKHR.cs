using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPhysicalDeviceDisplayPropertiesKHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice       physicalDevice,
                                                                                [NativeTypeName("uint32_t *")]           uint*                  pPropertyCount,
                                                                                ref                                      VkDisplayPropertiesKHR pProperties);
}
