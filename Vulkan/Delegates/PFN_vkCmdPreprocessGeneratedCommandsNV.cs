using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdPreprocessGeneratedCommandsNV([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                       [NativeTypeName("const VkGeneratedCommandsInfoNV *")]
                                                                       VkGeneratedCommandsInfoNV[] pGeneratedCommandsInfo);
}
