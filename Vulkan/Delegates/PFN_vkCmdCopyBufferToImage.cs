using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdCopyBufferToImage([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                           [NativeTypeName("VkBuffer")] ref    VkBuffer        srcBuffer,
                                                           [NativeTypeName("VkImage")] ref     VkImage         dstImage,
                                                           VkImageLayout                                       dstImageLayout,
                                                           [NativeTypeName("uint32_t")] uint                   regionCount,
                                                           [NativeTypeName("const VkBufferImageCopy *")]
                                                           VkBufferImageCopy[] pRegions);
}
