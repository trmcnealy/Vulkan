using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdPushDescriptorSetWithTemplateKHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                   [NativeTypeName("VkDescriptorUpdateTemplate")]
                                                                   ref VkDescriptorUpdateTemplate descriptorUpdateTemplate,
                                                                   [NativeTypeName("VkPipelineLayout")] ref VkPipelineLayout layout,
                                                                   [NativeTypeName("uint32_t")]             uint             set,
                                                                   [NativeTypeName("const void *")]         nint             pData);
}
