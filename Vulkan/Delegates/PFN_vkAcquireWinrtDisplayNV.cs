using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkAcquireWinrtDisplayNV([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                         [NativeTypeName("VkDisplayKHR")] ref     VkDisplayKHR     display);
}
