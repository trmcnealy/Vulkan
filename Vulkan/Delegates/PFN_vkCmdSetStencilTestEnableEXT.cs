using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetStencilTestEnableEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                          [NativeTypeName("VkBool32")]        uint            stencilTestEnable);
}
