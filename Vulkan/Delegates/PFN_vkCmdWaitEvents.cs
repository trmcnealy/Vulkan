using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdWaitEvents([NativeTypeName("VkCommandBuffer")]     VkCommandBuffer commandBuffer,
                                                    [NativeTypeName("uint32_t")]            uint            eventCount,
                                                    [NativeTypeName("const VkEvent *")] ref VkEvent*        pEvents,
                                                    [NativeTypeName("VkPipelineStageFlags")]
                                                    uint srcStageMask,
                                                    [NativeTypeName("VkPipelineStageFlags")]
                                                    uint dstStageMask,
                                                    [NativeTypeName("uint32_t")] uint memoryBarrierCount,
                                                    [NativeTypeName("const VkMemoryBarrier *")]
                                                    VkMemoryBarrier[] pMemoryBarriers,
                                                    [NativeTypeName("uint32_t")] uint bufferMemoryBarrierCount,
                                                    [NativeTypeName("const VkBufferMemoryBarrier *")]
                                                    VkBufferMemoryBarrier[] pBufferMemoryBarriers,
                                                    [NativeTypeName("uint32_t")] uint imageMemoryBarrierCount,
                                                    [NativeTypeName("const VkImageMemoryBarrier *")]
                                                    VkImageMemoryBarrier[] pImageMemoryBarriers);
}
