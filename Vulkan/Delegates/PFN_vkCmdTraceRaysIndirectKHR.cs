using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdTraceRaysIndirectKHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                              [NativeTypeName("const VkStridedDeviceAddressRegionKHR *")]
                                                              in VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable,
                                                              [NativeTypeName("const VkStridedDeviceAddressRegionKHR *")]
                                                              VkStridedDeviceAddressRegionKHR[] pMissShaderBindingTable,
                                                              [NativeTypeName("const VkStridedDeviceAddressRegionKHR *")]
                                                              in VkStridedDeviceAddressRegionKHR pHitShaderBindingTable,
                                                              [NativeTypeName("const VkStridedDeviceAddressRegionKHR *")]
                                                              in VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable,
                                                              [NativeTypeName("VkDeviceAddress")] ulong indirectDeviceAddress);
}
