using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkEnumerateInstanceExtensionProperties([NativeTypeName("const char *")]  utf8string pLayerName,
                                                                               [NativeTypeName("uint32_t *")]                                    uint*  pPropertyCount,
                                                                               VkExtensionProperties*                                                   pProperties);
}
