using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPhysicalDeviceToolPropertiesEXT([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                             [NativeTypeName("uint32_t *")]           uint*            pToolCount,
                                                                             VkPhysicalDeviceToolPropertiesEXT*                        pToolProperties);
}
