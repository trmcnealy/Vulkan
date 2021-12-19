using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetDeviceGroupSurfacePresentModes2EXT([NativeTypeName("VkDevice")] VkDevice device,
                                                                                [NativeTypeName("const VkPhysicalDeviceSurfaceInfo2KHR *")]
                                                                                VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
                                                                                [NativeTypeName("VkDeviceGroupPresentModeFlagsKHR *")]
                                                                                uint* pModes);
}
