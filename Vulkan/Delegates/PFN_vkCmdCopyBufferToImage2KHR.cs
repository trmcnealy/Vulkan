using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdCopyBufferToImage2KHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                               [NativeTypeName("const VkCopyBufferToImageInfo2KHR *")]
                                                               in VkCopyBufferToImageInfo2KHR pCopyBufferToImageInfo);
}
