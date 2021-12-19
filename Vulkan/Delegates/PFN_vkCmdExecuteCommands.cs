using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdExecuteCommands([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                         [NativeTypeName("uint32_t")]        uint            commandBufferCount,
                                                         [NativeTypeName("const VkCommandBuffer *")]
                                                         ref VkCommandBuffer[] pCommandBuffers);
}
