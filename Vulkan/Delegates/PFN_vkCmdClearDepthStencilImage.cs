using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdClearDepthStencilImage([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                [NativeTypeName("VkImage")] ref     VkImage         image,
                                                                VkImageLayout                                       imageLayout,
                                                                [NativeTypeName("const VkClearDepthStencilValue *")]
                                                                in VkClearDepthStencilValue pDepthStencil,
                                                                [NativeTypeName("uint32_t")] uint rangeCount,
                                                                [NativeTypeName("const VkImageSubresourceRange *")]
                                                                VkImageSubresourceRange[] pRanges);
}
