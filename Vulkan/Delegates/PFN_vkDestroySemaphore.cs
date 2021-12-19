using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroySemaphore([NativeTypeName("VkDevice")]        VkDevice    device,
                                                       [NativeTypeName("VkSemaphore")] ref VkSemaphore semaphore,
                                                       [NativeTypeName("const VkAllocationCallbacks *")]
                                                       in VkAllocationCallbacks pAllocator);
}
