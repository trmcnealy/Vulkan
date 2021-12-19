using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyFence([NativeTypeName("VkDevice")]    VkDevice device,
                                                   [NativeTypeName("VkFence")] ref VkFence  fence,
                                                   [NativeTypeName("const VkAllocationCallbacks *")]
                                                   in VkAllocationCallbacks pAllocator);
}
