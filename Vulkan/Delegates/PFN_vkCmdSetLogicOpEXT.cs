using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetLogicOpEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                VkLogicOp                                           logicOp);
}
