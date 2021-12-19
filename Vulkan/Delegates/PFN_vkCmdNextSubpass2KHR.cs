using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdNextSubpass2KHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                         [NativeTypeName("const VkSubpassBeginInfo *")]
                                                         VkSubpassBeginInfo[] pSubpassBeginInfo,
                                                         [NativeTypeName("const VkSubpassEndInfo *")]
                                                         VkSubpassEndInfo[] pSubpassEndInfo);
}
