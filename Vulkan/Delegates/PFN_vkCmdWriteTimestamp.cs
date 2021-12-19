using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdWriteTimestamp([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                 VkPipelineStageFlagBits                             pipelineStage,
                                                 [NativeTypeName("VkQueryPool")] ref VkQueryPool     queryPool,
                                                 [NativeTypeName("uint32_t")]        uint            query);
}
