using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdBlitImage2KHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                       [NativeTypeName("const VkBlitImageInfo2KHR *")]
                                                       in VkBlitImageInfo2KHR pBlitImageInfo);
}
