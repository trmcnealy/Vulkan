using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyCuFunctionNVX([NativeTypeName("VkDevice")]            VkDevice        device,
                                                           [NativeTypeName("VkCuFunctionNVX")] ref VkCuFunctionNVX function,
                                                           [NativeTypeName("const VkAllocationCallbacks *")]
                                                           in VkAllocationCallbacks pAllocator);
}
