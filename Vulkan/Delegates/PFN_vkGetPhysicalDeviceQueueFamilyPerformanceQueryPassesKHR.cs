using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                                            [NativeTypeName("const VkQueryPoolPerformanceCreateInfoKHR *")]
                                                                                            in VkQueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo,
                                                                                            [NativeTypeName("uint32_t *")] uint[] pNumPasses);
}
