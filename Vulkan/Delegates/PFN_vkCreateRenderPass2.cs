using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateRenderPass2([NativeTypeName("VkDevice")] VkDevice device,
                                                            [NativeTypeName("const VkRenderPassCreateInfo2 *")]
                                                            in VkRenderPassCreateInfo2 pCreateInfo,
                                                            [NativeTypeName("const VkAllocationCallbacks *")]
                                                            in VkAllocationCallbacks pAllocator,
                                                            [NativeTypeName("VkRenderPass *")] ref VkRenderPass[] pRenderPass);
}
