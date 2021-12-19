using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkBeginCommandBuffer([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                             [NativeTypeName("const VkCommandBufferBeginInfo *")]
                                                             in VkCommandBufferBeginInfo pBeginInfo);
}
