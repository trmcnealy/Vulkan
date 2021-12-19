using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                                                        [NativeTypeName("uint32_t")]             uint             queueFamilyIndex,
                                                                                                        [NativeTypeName("uint32_t *")]           uint*            pCounterCount,
                                                                                                        VkPerformanceCounterKHR*                                  pCounters,
                                                                                                        VkPerformanceCounterDescriptionKHR*                       pCounterDescriptions);
}
