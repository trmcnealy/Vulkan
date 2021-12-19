using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdSetDiscardRectangleEXT([NativeTypeName("VkCommandBuffer")]  VkCommandBuffer commandBuffer,
                                                                [NativeTypeName("uint32_t")]         uint            firstDiscardRectangle,
                                                                [NativeTypeName("uint32_t")]         uint            discardRectangleCount,
                                                                [NativeTypeName("const VkRect2D *")] VkRect2D*       pDiscardRectangles);
}
