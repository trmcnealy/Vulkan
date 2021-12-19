using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetPrimitiveTopologyEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                          VkPrimitiveTopology                                 primitiveTopology);
}
