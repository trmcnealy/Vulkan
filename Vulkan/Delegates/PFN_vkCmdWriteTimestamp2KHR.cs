using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdWriteTimestamp2KHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                     [NativeTypeName("VkPipelineStageFlags2KHR")]
                                                     ulong stage,
                                                     [NativeTypeName("VkQueryPool")] ref VkQueryPool queryPool,
                                                     [NativeTypeName("uint32_t")]        uint        query);
}
