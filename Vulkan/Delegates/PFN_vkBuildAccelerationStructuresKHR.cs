using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkBuildAccelerationStructuresKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                         [NativeTypeName("VkDeferredOperationKHR")]
                                                                         ref VkDeferredOperationKHR deferredOperation,
                                                                         [NativeTypeName("uint32_t")] uint infoCount,
                                                                         [NativeTypeName("const VkAccelerationStructureBuildGeometryInfoKHR *")]
                                                                         VkAccelerationStructureBuildGeometryInfoKHR[] pInfos,
                                                                         [NativeTypeName("const VkAccelerationStructureBuildRangeInfoKHR *const *")]
                                                                         VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);
}
