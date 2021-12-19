using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdBindDescriptorSets([NativeTypeName("VkCommandBuffer")] VkCommandBuffer       commandBuffer,
                                                            VkPipelineBindPoint                                       pipelineBindPoint,
                                                            [NativeTypeName("VkPipelineLayout")] VkPipelineLayout layout,
                                                            [NativeTypeName("uint32_t")]             uint             firstSet,
                                                            [NativeTypeName("uint32_t")]             uint             descriptorSetCount,
                                                            [NativeTypeName("const VkDescriptorSet *")]
                                                            VkDescriptorSet[] pDescriptorSets,
                                                            [NativeTypeName("uint32_t")]         uint  dynamicOffsetCount,
                                                            [NativeTypeName("const uint32_t *")] uint[] pDynamicOffsets);
}
