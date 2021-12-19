using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdSetViewportWithCountEXT([NativeTypeName("VkCommandBuffer")]    VkCommandBuffer commandBuffer,
                                                                 [NativeTypeName("uint32_t")]           uint            viewportCount,
                                                                 [NativeTypeName("const VkViewport *")] VkViewport*     pViewports);
}
