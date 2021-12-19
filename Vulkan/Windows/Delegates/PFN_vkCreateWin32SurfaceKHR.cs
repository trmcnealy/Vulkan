using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateWin32SurfaceKHR([NativeTypeName("VkInstance")] VkInstance instance,
                                                                [NativeTypeName("const VkWin32SurfaceCreateInfoKHR *")]
                                                                VkWin32SurfaceCreateInfoKHR* pCreateInfo,
                                                                [NativeTypeName("const VkAllocationCallbacks *")]
                                                                VkAllocationCallbacks* pAllocator,
                                                                [NativeTypeName("VkSurfaceKHR *")] ref VkSurfaceKHR* pSurface);
}
