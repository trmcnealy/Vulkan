using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyImageView([NativeTypeName("VkDevice")]        VkDevice    device,
                                                       [NativeTypeName("VkImageView")] ref VkImageView imageView,
                                                       [NativeTypeName("const VkAllocationCallbacks *")]
                                                       in VkAllocationCallbacks pAllocator);
}
