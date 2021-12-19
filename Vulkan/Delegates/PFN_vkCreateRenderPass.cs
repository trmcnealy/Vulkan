using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateRenderPass([NativeTypeName("VkDevice")] VkDevice device,
                                                           [NativeTypeName("const VkRenderPassCreateInfo *")]
                                                           in VkRenderPassCreateInfo pCreateInfo,
                                                           [NativeTypeName("const VkAllocationCallbacks *")]
                                                           in VkAllocationCallbacks pAllocator,
                                                           [NativeTypeName("VkRenderPass *")] out VkRenderPass pRenderPass);
}
