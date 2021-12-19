using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetWinrtDisplayNV([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                            [NativeTypeName("uint32_t")]             uint             deviceRelativeId,
                                                            [NativeTypeName("VkDisplayKHR *")] ref   VkDisplayKHR*    pDisplay);
}
