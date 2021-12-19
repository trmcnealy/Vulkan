using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetPrimitiveRestartEnableEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                               [NativeTypeName("VkBool32")]        uint            primitiveRestartEnable);
}
