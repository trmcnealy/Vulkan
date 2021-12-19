using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyFramebuffer([NativeTypeName("VkDevice")]          VkDevice      device,
                                                         [NativeTypeName("VkFramebuffer")] ref VkFramebuffer framebuffer,
                                                         [NativeTypeName("const VkAllocationCallbacks *")]
                                                         in VkAllocationCallbacks pAllocator);
}
