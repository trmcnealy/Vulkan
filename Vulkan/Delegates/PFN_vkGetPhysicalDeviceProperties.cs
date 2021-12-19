using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetPhysicalDeviceProperties([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                  VkPhysicalDeviceProperties*                               pProperties);
}
