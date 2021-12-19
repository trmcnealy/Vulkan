using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdSetFragmentShadingRateKHR([NativeTypeName("VkCommandBuffer")]    VkCommandBuffer commandBuffer,
                                                                   [NativeTypeName("const VkExtent2D *")] VkExtent2D*     pFragmentSize,
                                                                   [NativeTypeName("const VkFragmentShadingRateCombinerOpKHR [2]")]
                                                                   VkFragmentShadingRateCombinerOpKHR[] combinerOps);
}
