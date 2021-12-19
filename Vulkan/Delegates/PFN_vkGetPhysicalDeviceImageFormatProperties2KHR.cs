using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPhysicalDeviceImageFormatProperties2KHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                                     [NativeTypeName("const VkPhysicalDeviceImageFormatInfo2 *")]
                                                                                     in VkPhysicalDeviceImageFormatInfo2 pImageFormatInfo,
                                                                                     VkImageFormatProperties2[] pImageFormatProperties);
}
