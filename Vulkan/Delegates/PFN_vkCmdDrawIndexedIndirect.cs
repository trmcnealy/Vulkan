using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdDrawIndexedIndirect([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                      [NativeTypeName("VkBuffer")] ref    VkBuffer        buffer,
                                                      [NativeTypeName("VkDeviceSize")]    ulong           offset,
                                                      [NativeTypeName("uint32_t")]        uint            drawCount,
                                                      [NativeTypeName("uint32_t")]        uint            stride);
}
