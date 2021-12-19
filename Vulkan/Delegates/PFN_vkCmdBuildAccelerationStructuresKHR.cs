using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdBuildAccelerationStructuresKHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                        [NativeTypeName("uint32_t")]        uint            infoCount,
                                                                        [NativeTypeName("const VkAccelerationStructureBuildGeometryInfoKHR *")]
                                                                        VkAccelerationStructureBuildGeometryInfoKHR[] pInfos,
                                                                        [NativeTypeName("const VkAccelerationStructureBuildRangeInfoKHR *const *")]
                                                                        VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);
}
