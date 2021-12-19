using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateHeadlessSurfaceEXT([NativeTypeName("VkInstance")] VkInstance instance,
                                                                   [NativeTypeName("const VkHeadlessSurfaceCreateInfoEXT *")]
                                                                   in VkHeadlessSurfaceCreateInfoEXT pCreateInfo,
                                                                   [NativeTypeName("const VkAllocationCallbacks *")]
                                                                   in VkAllocationCallbacks pAllocator,
                                                                   [NativeTypeName("VkSurfaceKHR *")] out VkSurfaceKHR pSurface);
}
