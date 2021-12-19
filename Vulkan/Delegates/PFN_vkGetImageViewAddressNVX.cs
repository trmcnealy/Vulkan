using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetImageViewAddressNVX([NativeTypeName("VkDevice")]        VkDevice    device,
                                                                 [NativeTypeName("VkImageView")] ref VkImageView imageView,
                                                                 VkImageViewAddressPropertiesNVX*                pProperties);
}
