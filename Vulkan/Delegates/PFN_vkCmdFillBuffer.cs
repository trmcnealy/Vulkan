using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdFillBuffer([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                             [NativeTypeName("VkBuffer")] ref    VkBuffer        dstBuffer,
                                             [NativeTypeName("VkDeviceSize")]    ulong           dstOffset,
                                             [NativeTypeName("VkDeviceSize")]    ulong           size,
                                             [NativeTypeName("uint32_t")]        uint            data);
}
