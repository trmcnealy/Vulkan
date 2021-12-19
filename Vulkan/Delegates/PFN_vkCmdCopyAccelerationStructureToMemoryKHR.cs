using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdCopyAccelerationStructureToMemoryKHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                              [NativeTypeName("const VkCopyAccelerationStructureToMemoryInfoKHR *")]
                                                                              in VkCopyAccelerationStructureToMemoryInfoKHR pInfo);
}
