using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroySurfaceKHR([NativeTypeName("VkInstance")]       VkInstance   instance,
                                                        [NativeTypeName("VkSurfaceKHR")] ref VkSurfaceKHR surface,
                                                        [NativeTypeName("const VkAllocationCallbacks *")]
                                                        in VkAllocationCallbacks pAllocator);
}
