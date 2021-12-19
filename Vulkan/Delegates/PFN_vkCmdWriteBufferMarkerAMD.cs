using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdWriteBufferMarkerAMD([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                       VkPipelineStageFlagBits                             pipelineStage,
                                                       [NativeTypeName("VkBuffer")] ref VkBuffer           dstBuffer,
                                                       [NativeTypeName("VkDeviceSize")] ulong              dstOffset,
                                                       [NativeTypeName("uint32_t")]     uint               marker);
}
