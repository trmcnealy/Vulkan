using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetPhysicalDeviceExternalFenceProperties([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                                               [NativeTypeName("const VkPhysicalDeviceExternalFenceInfo *")]
                                                                               in VkPhysicalDeviceExternalFenceInfo pExternalFenceInfo,
                                                                               VkExternalFenceProperties[] pExternalFenceProperties);
}
