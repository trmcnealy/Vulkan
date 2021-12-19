using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdUpdateBuffer([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                               [NativeTypeName("VkBuffer")] ref    VkBuffer        dstBuffer,
                                               [NativeTypeName("VkDeviceSize")]    ulong           dstOffset,
                                               [NativeTypeName("VkDeviceSize")]    ulong           dataSize,
                                               [NativeTypeName("const void *")]    nint            pData);
}
