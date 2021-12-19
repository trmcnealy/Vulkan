using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdSetCoarseSampleOrderNV([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                VkCoarseSampleOrderTypeNV                           sampleOrderType,
                                                                [NativeTypeName("uint32_t")] uint                   customSampleOrderCount,
                                                                [NativeTypeName("const VkCoarseSampleOrderCustomNV *")]
                                                                VkCoarseSampleOrderCustomNV[] pCustomSampleOrders);
}
