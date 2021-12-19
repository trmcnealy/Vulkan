using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdCopyImageToBuffer([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                           [NativeTypeName("VkImage")] ref     VkImage         srcImage,
                                                           VkImageLayout                                       srcImageLayout,
                                                           [NativeTypeName("VkBuffer")] ref VkBuffer           dstBuffer,
                                                           [NativeTypeName("uint32_t")]     uint               regionCount,
                                                           [NativeTypeName("const VkBufferImageCopy *")]
                                                           VkBufferImageCopy[] pRegions);
}
