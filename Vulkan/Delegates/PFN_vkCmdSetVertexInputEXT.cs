using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdSetVertexInputEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                           [NativeTypeName("uint32_t")]        uint            vertexBindingDescriptionCount,
                                                           [NativeTypeName("const VkVertexInputBindingDescription2EXT *")]
                                                           VkVertexInputBindingDescription2EXT[] pVertexBindingDescriptions,
                                                           [NativeTypeName("uint32_t")] uint vertexAttributeDescriptionCount,
                                                           [NativeTypeName("const VkVertexInputAttributeDescription2EXT *")]
                                                           VkVertexInputAttributeDescription2EXT[] pVertexAttributeDescriptions);
}
