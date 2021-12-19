using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdSetScissorWithCountEXT([NativeTypeName("VkCommandBuffer")]  VkCommandBuffer commandBuffer,
                                                                [NativeTypeName("uint32_t")]         uint            scissorCount,
                                                                [NativeTypeName("const VkRect2D *")] VkRect2D*       pScissors);
}
