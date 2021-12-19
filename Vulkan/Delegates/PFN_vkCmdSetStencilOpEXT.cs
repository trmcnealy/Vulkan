using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetStencilOpEXT([NativeTypeName("VkCommandBuffer")]    VkCommandBuffer commandBuffer,
                                                  [NativeTypeName("VkStencilFaceFlags")] uint            faceMask,
                                                  VkStencilOp                                            failOp,
                                                  VkStencilOp                                            passOp,
                                                  VkStencilOp                                            depthFailOp,
                                                  VkCompareOp                                            compareOp);
}
