using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetDisplayPlaneCapabilities2KHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                          [NativeTypeName("const VkDisplayPlaneInfo2KHR *")]
                                                                          VkDisplayPlaneInfo2KHR[] pDisplayPlaneInfo,
                                                                          VkDisplayPlaneCapabilities2KHR[] pCapabilities);
}
