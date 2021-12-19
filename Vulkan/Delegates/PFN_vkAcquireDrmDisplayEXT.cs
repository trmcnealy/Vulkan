using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkAcquireDrmDisplayEXT([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                        [NativeTypeName("int32_t")]              int              drmFd,
                                                        [NativeTypeName("VkDisplayKHR")] ref     VkDisplayKHR     display);
}
