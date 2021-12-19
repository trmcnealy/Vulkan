using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetEvent([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                           [NativeTypeName("VkEvent")] ref     VkEvent         @event,
                                           [NativeTypeName("VkPipelineStageFlags")]
                                           uint stageMask);
}
