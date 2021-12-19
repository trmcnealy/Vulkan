using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateDisplayPlaneSurfaceKHR([NativeTypeName("VkInstance")] VkInstance instance,
                                                                       [NativeTypeName("const VkDisplaySurfaceCreateInfoKHR *")]
                                                                       in VkDisplaySurfaceCreateInfoKHR pCreateInfo,
                                                                       [NativeTypeName("const VkAllocationCallbacks *")]
                                                                       in VkAllocationCallbacks pAllocator,
                                                                       [NativeTypeName("VkSurfaceKHR *")] out VkSurfaceKHR pSurface);
}
