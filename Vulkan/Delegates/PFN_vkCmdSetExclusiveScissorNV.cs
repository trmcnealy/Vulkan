using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdSetExclusiveScissorNV([NativeTypeName("VkCommandBuffer")]  VkCommandBuffer commandBuffer,
                                                               [NativeTypeName("uint32_t")]         uint            firstExclusiveScissor,
                                                               [NativeTypeName("uint32_t")]         uint            exclusiveScissorCount,
                                                               [NativeTypeName("const VkRect2D *")] VkRect2D*       pExclusiveScissors);
}
