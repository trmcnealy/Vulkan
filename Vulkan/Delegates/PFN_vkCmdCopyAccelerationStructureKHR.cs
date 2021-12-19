using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdCopyAccelerationStructureKHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                      [NativeTypeName("const VkCopyAccelerationStructureInfoKHR *")]
                                                                      in VkCopyAccelerationStructureInfoKHR pInfo);
}
