using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdExecuteGeneratedCommandsNV([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                    [NativeTypeName("VkBool32")]        uint            isPreprocessed,
                                                                    [NativeTypeName("const VkGeneratedCommandsInfoNV *")]
                                                                    VkGeneratedCommandsInfoNV[] pGeneratedCommandsInfo);
}
