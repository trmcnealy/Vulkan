using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdSetViewportShadingRatePaletteNV([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                         [NativeTypeName("uint32_t")]        uint            firstViewport,
                                                                         [NativeTypeName("uint32_t")]        uint            viewportCount,
                                                                         [NativeTypeName("const VkShadingRatePaletteNV *")]
                                                                         VkShadingRatePaletteNV[] pShadingRatePalettes);
}
