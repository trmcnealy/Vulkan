using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdPipelineBarrier([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                         [NativeTypeName("VkPipelineStageFlags")]
                                                         uint srcStageMask,
                                                         [NativeTypeName("VkPipelineStageFlags")]
                                                         uint dstStageMask,
                                                         [NativeTypeName("VkDependencyFlags")] uint dependencyFlags,
                                                         [NativeTypeName("uint32_t")]          uint memoryBarrierCount,
                                                         [NativeTypeName("const VkMemoryBarrier *")]
                                                         VkMemoryBarrier[] pMemoryBarriers,
                                                         [NativeTypeName("uint32_t")] uint bufferMemoryBarrierCount,
                                                         [NativeTypeName("const VkBufferMemoryBarrier *")]
                                                         VkBufferMemoryBarrier[] pBufferMemoryBarriers,
                                                         [NativeTypeName("uint32_t")] uint imageMemoryBarrierCount,
                                                         [NativeTypeName("const VkImageMemoryBarrier *")]
                                                         VkImageMemoryBarrier[] pImageMemoryBarriers);
}
