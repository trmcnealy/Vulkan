using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkFreeCommandBuffers([NativeTypeName("VkDevice")]          VkDevice      device,
                                                         [NativeTypeName("VkCommandPool")] ref VkCommandPool commandPool,
                                                         [NativeTypeName("uint32_t")]          uint          commandBufferCount,
                                                         [NativeTypeName("const VkCommandBuffer *")]
                                                         ref VkCommandBuffer[] pCommandBuffers);
}
