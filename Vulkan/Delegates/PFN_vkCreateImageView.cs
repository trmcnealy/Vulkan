using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateImageView([NativeTypeName("VkDevice")] VkDevice device,
                                                          [NativeTypeName("const VkImageViewCreateInfo *")]
                                                          in VkImageViewCreateInfo pCreateInfo,
                                                          [NativeTypeName("const VkAllocationCallbacks *")]
                                                          in VkAllocationCallbacks pAllocator,
                                                          [NativeTypeName("VkImageView *")] out VkImageView pView);
}
