using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetDepthBias([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                               float                                               depthBiasConstantFactor,
                                               float                                               depthBiasClamp,
                                               float                                               depthBiasSlopeFactor);
}
