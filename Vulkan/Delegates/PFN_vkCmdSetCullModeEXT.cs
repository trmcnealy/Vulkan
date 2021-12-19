using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetCullModeEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                 [NativeTypeName("VkCullModeFlags")] uint            cullMode);
}
