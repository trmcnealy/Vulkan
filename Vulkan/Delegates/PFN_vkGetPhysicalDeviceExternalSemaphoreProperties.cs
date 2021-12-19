using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetPhysicalDeviceExternalSemaphoreProperties([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                                   [NativeTypeName("const VkPhysicalDeviceExternalSemaphoreInfo *")]
                                                                                   in VkPhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo,
                                                                                   VkExternalSemaphoreProperties[] pExternalSemaphoreProperties);
}
