using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName(                                                                "VkBool32")]
    public delegate uint PFN_vkGetPhysicalDeviceWin32PresentationSupportKHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                            [NativeTypeName("uint32_t")]             uint             queueFamilyIndex);
}
