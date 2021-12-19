using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPhysicalDeviceExternalImageFormatPropertiesNV([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                                           VkFormat                                                  format,
                                                                                           VkImageType                                               type,
                                                                                           VkImageTiling                                             tiling,
                                                                                           [NativeTypeName("VkImageUsageFlags")]  uint               usage,
                                                                                           [NativeTypeName("VkImageCreateFlags")] uint               flags,
                                                                                           [NativeTypeName("VkExternalMemoryHandleTypeFlagsNV")]
                                                                                           uint externalHandleType,
                                                                                           VkExternalImageFormatPropertiesNV[] pExternalImageFormatProperties);
}
