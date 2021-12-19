using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdDrawIndirectCountKHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                       [NativeTypeName("VkBuffer")] ref    VkBuffer        buffer,
                                                       [NativeTypeName("VkDeviceSize")]    ulong           offset,
                                                       [NativeTypeName("VkBuffer")] ref    VkBuffer        countBuffer,
                                                       [NativeTypeName("VkDeviceSize")]    ulong           countBufferOffset,
                                                       [NativeTypeName("uint32_t")]        uint            maxDrawCount,
                                                       [NativeTypeName("uint32_t")]        uint            stride);
}
