using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdResetEvent2KHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                 [NativeTypeName("VkEvent")] ref     VkEvent         @event,
                                                 [NativeTypeName("VkPipelineStageFlags2KHR")]
                                                 ulong stageMask);
}
