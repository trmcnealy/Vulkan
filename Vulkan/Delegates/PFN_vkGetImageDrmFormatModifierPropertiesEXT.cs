using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetImageDrmFormatModifierPropertiesEXT([NativeTypeName("VkDevice")]    VkDevice device,
                                                                                 [NativeTypeName("VkImage")] ref VkImage  image,
                                                                                 VkImageDrmFormatModifierPropertiesEXT*   pProperties);
}
