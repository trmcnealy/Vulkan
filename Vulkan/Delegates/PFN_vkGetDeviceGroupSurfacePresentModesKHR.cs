using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetDeviceGroupSurfacePresentModesKHR([NativeTypeName("VkDevice")]         VkDevice     device,
                                                                               [NativeTypeName("VkSurfaceKHR")] ref VkSurfaceKHR surface,
                                                                               [NativeTypeName("VkDeviceGroupPresentModeFlagsKHR *")]
                                                                               uint[] pModes);
}
