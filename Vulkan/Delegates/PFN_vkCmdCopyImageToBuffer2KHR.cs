using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdCopyImageToBuffer2KHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                               [NativeTypeName("const VkCopyImageToBufferInfo2KHR *")]
                                                               in VkCopyImageToBufferInfo2KHR pCopyImageToBufferInfo);
}
