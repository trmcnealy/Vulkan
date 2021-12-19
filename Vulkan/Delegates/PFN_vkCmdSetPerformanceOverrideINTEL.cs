using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCmdSetPerformanceOverrideINTEL([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                         [NativeTypeName("const VkPerformanceOverrideInfoINTEL *")]
                                                                         in VkPerformanceOverrideInfoINTEL pOverrideInfo);
}
