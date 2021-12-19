using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdDrawMultiIndexedEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                             [NativeTypeName("uint32_t")]        uint            drawCount,
                                                             [NativeTypeName("const VkMultiDrawIndexedInfoEXT *")]
                                                             in VkMultiDrawIndexedInfoEXT pIndexInfo,
                                                             [NativeTypeName("uint32_t")]        uint instanceCount,
                                                             [NativeTypeName("uint32_t")]        uint firstInstance,
                                                             [NativeTypeName("uint32_t")]        uint stride,
                                                             [NativeTypeName("const int32_t *")] int[] pVertexOffset);
}
