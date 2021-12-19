using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdCopyQueryPoolResults([NativeTypeName("VkCommandBuffer")]    VkCommandBuffer commandBuffer,
                                                       [NativeTypeName("VkQueryPool")] ref    VkQueryPool     queryPool,
                                                       [NativeTypeName("uint32_t")]           uint            firstQuery,
                                                       [NativeTypeName("uint32_t")]           uint            queryCount,
                                                       [NativeTypeName("VkBuffer")] ref       VkBuffer        dstBuffer,
                                                       [NativeTypeName("VkDeviceSize")]       ulong           dstOffset,
                                                       [NativeTypeName("VkDeviceSize")]       ulong           stride,
                                                       [NativeTypeName("VkQueryResultFlags")] uint            flags);
}
