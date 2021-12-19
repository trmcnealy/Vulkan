using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetStencilReference([NativeTypeName("VkCommandBuffer")]    VkCommandBuffer commandBuffer,
                                                      [NativeTypeName("VkStencilFaceFlags")] uint            faceMask,
                                                      [NativeTypeName("uint32_t")]           uint            reference);
}
