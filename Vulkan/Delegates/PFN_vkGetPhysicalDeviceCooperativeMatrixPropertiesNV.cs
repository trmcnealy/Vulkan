using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPhysicalDeviceCooperativeMatrixPropertiesNV([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                                         [NativeTypeName("uint32_t *")]           uint*            pPropertyCount,
                                                                                         VkCooperativeMatrixPropertiesNV*                          pProperties);
}
