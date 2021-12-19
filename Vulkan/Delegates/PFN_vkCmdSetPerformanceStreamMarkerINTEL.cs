using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCmdSetPerformanceStreamMarkerINTEL([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                             [NativeTypeName("const VkPerformanceStreamMarkerInfoINTEL *")]
                                                                             in VkPerformanceStreamMarkerInfoINTEL pMarkerInfo);
}
