using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetDisplayPlaneCapabilitiesKHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                         [NativeTypeName("VkDisplayModeKHR")] ref VkDisplayModeKHR mode,
                                                                         [NativeTypeName("uint32_t")]             uint             planeIndex,
                                                                         VkDisplayPlaneCapabilitiesKHR*                            pCapabilities);
}
