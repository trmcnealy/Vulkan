using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdWriteBufferMarker2AMD([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                        [NativeTypeName("VkPipelineStageFlags2KHR")]
                                                        ulong stage,
                                                        [NativeTypeName("VkBuffer")] ref VkBuffer dstBuffer,
                                                        [NativeTypeName("VkDeviceSize")] ulong    dstOffset,
                                                        [NativeTypeName("uint32_t")]     uint     marker);
}
