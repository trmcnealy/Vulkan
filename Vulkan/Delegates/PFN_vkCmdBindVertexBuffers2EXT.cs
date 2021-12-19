using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdBindVertexBuffers2EXT([NativeTypeName("VkCommandBuffer")]      VkCommandBuffer commandBuffer,
                                                               [NativeTypeName("uint32_t")]             uint            firstBinding,
                                                               [NativeTypeName("uint32_t")]             uint            bindingCount,
                                                               [NativeTypeName("const VkBuffer *")] ref VkBuffer*       pBuffers,
                                                               [NativeTypeName("const VkDeviceSize *")]
                                                               ulong[] pOffsets,
                                                               [NativeTypeName("const VkDeviceSize *")]
                                                               ulong[] pSizes,
                                                               [NativeTypeName("const VkDeviceSize *")]
                                                               ulong[] pStrides);
}
