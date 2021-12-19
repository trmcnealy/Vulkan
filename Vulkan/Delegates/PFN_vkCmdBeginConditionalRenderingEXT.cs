using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdBeginConditionalRenderingEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                      [NativeTypeName("const VkConditionalRenderingBeginInfoEXT *")]
                                                                      in VkConditionalRenderingBeginInfoEXT pConditionalRenderingBegin);
}
