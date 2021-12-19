using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetDisplayPlaneSupportedDisplaysKHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                              [NativeTypeName("uint32_t")]             uint             planeIndex,
                                                                              [NativeTypeName("uint32_t *")]           uint*            pDisplayCount,
                                                                              [NativeTypeName("VkDisplayKHR *")] ref   VkDisplayKHR*    pDisplays);
}
