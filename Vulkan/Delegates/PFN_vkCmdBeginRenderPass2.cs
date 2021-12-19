using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdBeginRenderPass2([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                          [NativeTypeName("const VkRenderPassBeginInfo *")]
                                                          VkRenderPassBeginInfo[] pRenderPassBegin,
                                                          [NativeTypeName("const VkSubpassBeginInfo *")]
                                                          VkSubpassBeginInfo[] pSubpassBeginInfo);
}
