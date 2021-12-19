using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetDeviceGroupPresentCapabilitiesKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                               VkDeviceGroupPresentCapabilitiesKHR*  pDeviceGroupPresentCapabilities);
}
