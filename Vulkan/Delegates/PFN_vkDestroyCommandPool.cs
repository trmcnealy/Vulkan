using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyCommandPool([NativeTypeName("VkDevice")]          VkDevice      device,
                                                         [NativeTypeName("VkCommandPool")] ref VkCommandPool commandPool,
                                                         [NativeTypeName("const VkAllocationCallbacks *")]
                                                         in VkAllocationCallbacks pAllocator);
}
