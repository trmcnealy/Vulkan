using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdDrawIndexed([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                              [NativeTypeName("uint32_t")]        uint            indexCount,
                                              [NativeTypeName("uint32_t")]        uint            instanceCount,
                                              [NativeTypeName("uint32_t")]        uint            firstIndex,
                                              [NativeTypeName("int32_t")]         int             vertexOffset,
                                              [NativeTypeName("uint32_t")]        uint            firstInstance);
}
