using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdNextSubpass([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                              VkSubpassContents                                   contents);
}
