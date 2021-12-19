using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetDrmDisplayEXT([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                           [NativeTypeName("int32_t")]              int              drmFd,
                                                           [NativeTypeName("uint32_t")]             uint             connectorId,
                                                           [NativeTypeName("VkDisplayKHR *")] ref   VkDisplayKHR*    display);
}
