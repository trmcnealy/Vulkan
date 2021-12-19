using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateFramebuffer([NativeTypeName("VkDevice")] VkDevice device,
                                                            [NativeTypeName("const VkFramebufferCreateInfo *")]
                                                            in VkFramebufferCreateInfo pCreateInfo,
                                                            [NativeTypeName("const VkAllocationCallbacks *")]
                                                            in VkAllocationCallbacks pAllocator,
                                                            [NativeTypeName("VkFramebuffer *")] out VkFramebuffer pFramebuffer);
}
