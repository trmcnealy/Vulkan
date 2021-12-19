using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetImageSubresourceLayout([NativeTypeName("VkDevice")]    VkDevice device,
                                                                [NativeTypeName("VkImage")] ref VkImage  image,
                                                                [NativeTypeName("const VkImageSubresource *")]
                                                                VkImageSubresource[] pSubresource,
                                                                in VkSubresourceLayout pLayout);
}
