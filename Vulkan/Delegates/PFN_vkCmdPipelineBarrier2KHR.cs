using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdPipelineBarrier2KHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                             [NativeTypeName("const VkDependencyInfoKHR *")]
                                                             in VkDependencyInfoKHR pDependencyInfo);
}
