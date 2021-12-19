using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdBindTransformFeedbackBuffersEXT([NativeTypeName("VkCommandBuffer")]      VkCommandBuffer commandBuffer,
                                                                         [NativeTypeName("uint32_t")]             uint            firstBinding,
                                                                         [NativeTypeName("uint32_t")]             uint            bindingCount,
                                                                         [NativeTypeName("const VkBuffer *")] VkBuffer[]       pBuffers,
                                                                         [NativeTypeName("const VkDeviceSize *")]
                                                                         ulong[] pOffsets,
                                                                         [NativeTypeName("const VkDeviceSize *")]
                                                                         ulong[] pSizes);
}
