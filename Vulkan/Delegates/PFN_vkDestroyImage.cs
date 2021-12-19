using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyImage([NativeTypeName("VkDevice")]    VkDevice device,
                                                   [NativeTypeName("VkImage")] ref VkImage  image,
                                                   [NativeTypeName("const VkAllocationCallbacks *")]
                                                   in VkAllocationCallbacks pAllocator);
}
