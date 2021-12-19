using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkAllocateCommandBuffers([NativeTypeName("VkDevice")] VkDevice device,
                                                                 [NativeTypeName("const VkCommandBufferAllocateInfo *")]
                                                                 in VkCommandBufferAllocateInfo pAllocateInfo,
                                                                 [NativeTypeName("VkCommandBuffer *")] ref VkCommandBuffer[] pCommandBuffers);
}
