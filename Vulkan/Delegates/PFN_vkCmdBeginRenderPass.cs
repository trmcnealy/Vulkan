using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdBeginRenderPass([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                         [NativeTypeName("const VkRenderPassBeginInfo *")]
                                                         VkRenderPassBeginInfo[] pRenderPassBegin,
                                                         VkSubpassContents contents);
}
