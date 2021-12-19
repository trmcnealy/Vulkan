using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdTraceRaysKHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                      [NativeTypeName("const VkStridedDeviceAddressRegionKHR *")]
                                                      in VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable,
                                                      [NativeTypeName("const VkStridedDeviceAddressRegionKHR *")]
                                                      VkStridedDeviceAddressRegionKHR[] pMissShaderBindingTable,
                                                      [NativeTypeName("const VkStridedDeviceAddressRegionKHR *")]
                                                      in VkStridedDeviceAddressRegionKHR pHitShaderBindingTable,
                                                      [NativeTypeName("const VkStridedDeviceAddressRegionKHR *")]
                                                      in VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable,
                                                      [NativeTypeName("uint32_t")] uint width,
                                                      [NativeTypeName("uint32_t")] uint height,
                                                      [NativeTypeName("uint32_t")] uint depth);
}
