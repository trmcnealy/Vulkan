using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetDeviceMask([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                [NativeTypeName("uint32_t")]        uint            deviceMask);
}
