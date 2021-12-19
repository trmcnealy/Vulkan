using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetDepthCompareOpEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                       VkCompareOp                                         depthCompareOp);
}
