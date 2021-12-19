using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdPushDescriptorSetKHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer       commandBuffer,
                                                              VkPipelineBindPoint                                       pipelineBindPoint,
                                                              [NativeTypeName("VkPipelineLayout")] ref VkPipelineLayout layout,
                                                              [NativeTypeName("uint32_t")]             uint             set,
                                                              [NativeTypeName("uint32_t")]             uint             descriptorWriteCount,
                                                              [NativeTypeName("const VkWriteDescriptorSet *")]
                                                              VkWriteDescriptorSet[] pDescriptorWrites);
}
