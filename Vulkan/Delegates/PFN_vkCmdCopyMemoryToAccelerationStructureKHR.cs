using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdCopyMemoryToAccelerationStructureKHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                              [NativeTypeName("const VkCopyMemoryToAccelerationStructureInfoKHR *")]
                                                                              in VkCopyMemoryToAccelerationStructureInfoKHR pInfo);
}
