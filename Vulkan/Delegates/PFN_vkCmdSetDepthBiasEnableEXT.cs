using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetDepthBiasEnableEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                        [NativeTypeName("VkBool32")]        uint            depthBiasEnable);
}
