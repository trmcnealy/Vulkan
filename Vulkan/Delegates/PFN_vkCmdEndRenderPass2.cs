using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdEndRenderPass2([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                        [NativeTypeName("const VkSubpassEndInfo *")]
                                                        VkSubpassEndInfo[] pSubpassEndInfo);
}
