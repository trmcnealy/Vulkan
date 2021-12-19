using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdBindPipelineShaderGroupNV([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                            VkPipelineBindPoint                                 pipelineBindPoint,
                                                            [NativeTypeName("VkPipeline")] ref VkPipeline       pipeline,
                                                            [NativeTypeName("uint32_t")]       uint             groupIndex);
}
