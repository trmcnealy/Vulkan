using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetAccelerationStructureBuildSizesKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                            VkAccelerationStructureBuildTypeKHR   buildType,
                                                                            [NativeTypeName("const VkAccelerationStructureBuildGeometryInfoKHR *")]
                                                                            in VkAccelerationStructureBuildGeometryInfoKHR pBuildInfo,
                                                                            [NativeTypeName("const uint32_t *")] uint[] pMaxPrimitiveCounts,
                                                                            VkAccelerationStructureBuildSizesInfoKHR*  pSizeInfo);
}
