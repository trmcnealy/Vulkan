using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetLineWidth([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                               float                                               lineWidth);
}
