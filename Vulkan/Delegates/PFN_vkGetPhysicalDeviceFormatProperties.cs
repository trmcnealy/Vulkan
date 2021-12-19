using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetPhysicalDeviceFormatProperties([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                        VkFormat                                                  format,
                                                                        VkFormatProperties*                                       pFormatProperties);
}
