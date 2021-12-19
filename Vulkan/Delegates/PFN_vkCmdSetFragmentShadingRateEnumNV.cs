using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetFragmentShadingRateEnumNV([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                               VkFragmentShadingRateNV                             shadingRate,
                                                               [NativeTypeName("const VkFragmentShadingRateCombinerOpKHR [2]")] [MarshalAs(UnmanagedType.LPArray, SizeConst = 2)]
                                                               VkFragmentShadingRateCombinerOpKHR[] combinerOps);
}
