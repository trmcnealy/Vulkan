using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetPhysicalDeviceSparseImageFormatProperties([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                                   VkFormat                                                  format,
                                                                                   VkImageType                                               type,
                                                                                   VkSampleCountFlagBits                                     samples,
                                                                                   [NativeTypeName("VkImageUsageFlags")] uint                usage,
                                                                                   VkImageTiling                                             tiling,
                                                                                   [NativeTypeName("uint32_t *")] uint*                      pPropertyCount,
                                                                                   VkSparseImageFormatProperties*                            pProperties);
}
