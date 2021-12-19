using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetDepthBounds([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                 float                                               minDepthBounds,
                                                 float                                               maxDepthBounds);
}
