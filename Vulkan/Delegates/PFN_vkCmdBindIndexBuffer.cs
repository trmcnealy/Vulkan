using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdBindIndexBuffer([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                  [NativeTypeName("VkBuffer")] ref    VkBuffer        buffer,
                                                  [NativeTypeName("VkDeviceSize")]    ulong           offset,
                                                  VkIndexType                                         indexType);
}
