using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkEnumerateDeviceExtensionProperties([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                             [NativeTypeName("const char *")] 
                                                                             utf8string pLayerName,
                                                                             [NativeTypeName("uint32_t *")] in uint pPropertyCount,
                                                                             VkExtensionProperties*               pProperties);
}
