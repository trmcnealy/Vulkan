using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdCopyAccelerationStructureNV([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                              [NativeTypeName("VkAccelerationStructureNV")]
                                                              ref VkAccelerationStructureNV dst,
                                                              [NativeTypeName("VkAccelerationStructureNV")]
                                                              ref VkAccelerationStructureNV src,
                                                              VkCopyAccelerationStructureModeKHR mode);
}
