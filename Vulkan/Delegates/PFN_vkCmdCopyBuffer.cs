using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdCopyBuffer([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                    [NativeTypeName("VkBuffer")] ref    VkBuffer        srcBuffer,
                                                    [NativeTypeName("VkBuffer")] ref    VkBuffer        dstBuffer,
                                                    [NativeTypeName("uint32_t")]        uint            regionCount,
                                                    [NativeTypeName("const VkBufferCopy *")]
                                                    VkBufferCopy[] pRegions);
}
