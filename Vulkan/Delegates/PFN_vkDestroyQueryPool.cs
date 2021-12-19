using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyQueryPool([NativeTypeName("VkDevice")]        VkDevice    device,
                                                       [NativeTypeName("VkQueryPool")] ref VkQueryPool queryPool,
                                                       [NativeTypeName("const VkAllocationCallbacks *")]
                                                       in VkAllocationCallbacks pAllocator);
}
