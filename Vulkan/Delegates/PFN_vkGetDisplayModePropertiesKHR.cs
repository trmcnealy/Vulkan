using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetDisplayModePropertiesKHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                      [NativeTypeName("VkDisplayKHR")] ref     VkDisplayKHR     display,
                                                                      [NativeTypeName("uint32_t *")]           uint*            pPropertyCount,
                                                                      VkDisplayModePropertiesKHR*                               pProperties);
}
