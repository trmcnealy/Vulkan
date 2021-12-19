using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkLayerDestroyDevice([NativeTypeName("VkDevice")] ref VkDevice physicalDevice,
                                                         [NativeTypeName("const VkAllocationCallbacks *")]
                                                         in VkAllocationCallbacks pAllocator,
                                                         [NativeTypeName("PFN_vkDestroyDevice")]
                                                         nint destroyFunction);
}
