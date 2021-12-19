using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdEndQuery([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                           [NativeTypeName("VkQueryPool")] ref VkQueryPool     queryPool,
                                           [NativeTypeName("uint32_t")]        uint            query);
}
