using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdEndConditionalRenderingEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer);
}
