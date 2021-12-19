using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdDrawMultiEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                      [NativeTypeName("uint32_t")]        uint            drawCount,
                                                      [NativeTypeName("const VkMultiDrawInfoEXT *")]
                                                      in VkMultiDrawInfoEXT pVertexInfo,
                                                      [NativeTypeName("uint32_t")] uint instanceCount,
                                                      [NativeTypeName("uint32_t")] uint firstInstance,
                                                      [NativeTypeName("uint32_t")] uint stride);
}
