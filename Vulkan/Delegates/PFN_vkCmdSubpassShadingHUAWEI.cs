using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSubpassShadingHUAWEI([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer);
}
