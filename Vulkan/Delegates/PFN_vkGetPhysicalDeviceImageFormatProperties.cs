using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPhysicalDeviceImageFormatProperties([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                                 VkFormat                                                  format,
                                                                                 VkImageType                                               type,
                                                                                 VkImageTiling                                             tiling,
                                                                                 [NativeTypeName("VkImageUsageFlags")]  uint               usage,
                                                                                 [NativeTypeName("VkImageCreateFlags")] uint               flags,
                                                                                 VkImageFormatProperties*                                  pImageFormatProperties);
}
