using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdResolveImage2KHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                          [NativeTypeName("const VkResolveImageInfo2KHR *")]
                                                          VkResolveImageInfo2KHR[] pResolveImageInfo);
}
