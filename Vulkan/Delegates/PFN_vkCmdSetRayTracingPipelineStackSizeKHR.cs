using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetRayTracingPipelineStackSizeKHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                    [NativeTypeName("uint32_t")]        uint            pipelineStackSize);
}
