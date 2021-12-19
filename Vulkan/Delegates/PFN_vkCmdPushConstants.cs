using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdPushConstants([NativeTypeName("VkCommandBuffer")]      VkCommandBuffer  commandBuffer,
                                                [NativeTypeName("VkPipelineLayout")] ref VkPipelineLayout layout,
                                                [NativeTypeName("VkShaderStageFlags")]   uint             stageFlags,
                                                [NativeTypeName("uint32_t")]             uint             offset,
                                                [NativeTypeName("uint32_t")]             uint             size,
                                                [NativeTypeName("const void *")]         nint             pValues);
}
