using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdWaitEvents2KHR([NativeTypeName("VkCommandBuffer")]     VkCommandBuffer commandBuffer,
                                                        [NativeTypeName("uint32_t")]            uint            eventCount,
                                                        [NativeTypeName("const VkEvent *")] ref VkEvent*        pEvents,
                                                        [NativeTypeName("const VkDependencyInfoKHR *")]
                                                        VkDependencyInfoKHR[] pDependencyInfos);
}
