using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdBindPipeline([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                               VkPipelineBindPoint                                 pipelineBindPoint,
                                               [NativeTypeName("VkPipeline")] ref VkPipeline       pipeline);
}
