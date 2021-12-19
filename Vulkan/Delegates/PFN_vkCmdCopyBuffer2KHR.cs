using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdCopyBuffer2KHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                        [NativeTypeName("const VkCopyBufferInfo2KHR *")]
                                                        in VkCopyBufferInfo2KHR pCopyBufferInfo);
}
