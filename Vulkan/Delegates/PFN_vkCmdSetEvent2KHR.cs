using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdSetEvent2KHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                      [NativeTypeName("VkEvent")] ref     VkEvent         @event,
                                                      [NativeTypeName("const VkDependencyInfoKHR *")]
                                                      in VkDependencyInfoKHR pDependencyInfo);
}
