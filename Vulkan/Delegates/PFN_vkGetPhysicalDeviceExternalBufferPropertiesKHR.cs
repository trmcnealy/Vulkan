using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetPhysicalDeviceExternalBufferPropertiesKHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                                   [NativeTypeName("const VkPhysicalDeviceExternalBufferInfo *")]
                                                                                   in VkPhysicalDeviceExternalBufferInfo pExternalBufferInfo,
                                                                                   VkExternalBufferProperties[] pExternalBufferProperties);
}
