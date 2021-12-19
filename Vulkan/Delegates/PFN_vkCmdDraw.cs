using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdDraw([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                       [NativeTypeName("uint32_t")]        uint            vertexCount,
                                       [NativeTypeName("uint32_t")]        uint            instanceCount,
                                       [NativeTypeName("uint32_t")]        uint            firstVertex,
                                       [NativeTypeName("uint32_t")]        uint            firstInstance);
}
