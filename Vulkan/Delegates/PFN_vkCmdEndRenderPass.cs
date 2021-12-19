using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdEndRenderPass([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer);
}
