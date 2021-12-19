using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateDisplayModeKHR([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                               [NativeTypeName("VkDisplayKHR")] ref     VkDisplayKHR     display,
                                                               [NativeTypeName("const VkDisplayModeCreateInfoKHR *")]
                                                               in VkDisplayModeCreateInfoKHR pCreateInfo,
                                                               [NativeTypeName("const VkAllocationCallbacks *")]
                                                               in VkAllocationCallbacks pAllocator,
                                                               [NativeTypeName("VkDisplayModeKHR *")] out VkDisplayModeKHR pMode);
}
