using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdResolveImage([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                      [NativeTypeName("VkImage")] ref     VkImage         srcImage,
                                                      VkImageLayout                                       srcImageLayout,
                                                      [NativeTypeName("VkImage")] ref VkImage             dstImage,
                                                      VkImageLayout                                       dstImageLayout,
                                                      [NativeTypeName("uint32_t")] uint                   regionCount,
                                                      [NativeTypeName("const VkImageResolve *")]
                                                      VkImageResolve[] pRegions);
}
