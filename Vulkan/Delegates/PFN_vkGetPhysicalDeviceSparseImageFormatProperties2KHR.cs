using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                                       [NativeTypeName("const VkPhysicalDeviceSparseImageFormatInfo2 *")]
                                                                                       in VkPhysicalDeviceSparseImageFormatInfo2 pFormatInfo,
                                                                                       [NativeTypeName("uint32_t *")] in uint pPropertyCount,
                                                                                       VkSparseImageFormatProperties2*      pProperties);
}
