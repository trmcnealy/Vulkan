using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdEndTransformFeedbackEXT([NativeTypeName("VkCommandBuffer")]      VkCommandBuffer commandBuffer,
                                                                 [NativeTypeName("uint32_t")]             uint            firstCounterBuffer,
                                                                 [NativeTypeName("uint32_t")]             uint            counterBufferCount,
                                                                 [NativeTypeName("const VkBuffer *")] ref VkBuffer*       pCounterBuffers,
                                                                 [NativeTypeName("const VkDeviceSize *")]
                                                                 ulong[] pCounterBufferOffsets);
}
