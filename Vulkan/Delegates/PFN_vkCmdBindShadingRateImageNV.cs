using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdBindShadingRateImageNV([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                         [NativeTypeName("VkImageView")] ref VkImageView     imageView,
                                                         VkImageLayout                                       imageLayout);
}
