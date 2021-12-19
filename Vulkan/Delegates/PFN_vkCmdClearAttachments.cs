using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdClearAttachments([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                          [NativeTypeName("uint32_t")]        uint            attachmentCount,
                                                          [NativeTypeName("const VkClearAttachment *")]
                                                          VkClearAttachment[] pAttachments,
                                                          [NativeTypeName("uint32_t")] uint rectCount,
                                                          [NativeTypeName("const VkClearRect *")]
                                                          VkClearRect[] pRects);
}
