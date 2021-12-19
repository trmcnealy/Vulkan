using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdCuLaunchKernelNVX([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                           [NativeTypeName("const VkCuLaunchInfoNVX *")]
                                                           in VkCuLaunchInfoNVX pLaunchInfo);
}
