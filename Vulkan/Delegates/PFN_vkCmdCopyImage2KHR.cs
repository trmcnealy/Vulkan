using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdCopyImage2KHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                       [NativeTypeName("const VkCopyImageInfo2KHR *")]
                                                       in VkCopyImageInfo2KHR pCopyImageInfo);
}
