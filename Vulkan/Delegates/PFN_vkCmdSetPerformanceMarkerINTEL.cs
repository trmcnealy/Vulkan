using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCmdSetPerformanceMarkerINTEL([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                       [NativeTypeName("const VkPerformanceMarkerInfoINTEL *")]
                                                                       in VkPerformanceMarkerInfoINTEL pMarkerInfo);
}
