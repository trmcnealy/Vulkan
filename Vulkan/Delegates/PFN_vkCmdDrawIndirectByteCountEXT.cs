using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdDrawIndirectByteCountEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                           [NativeTypeName("uint32_t")]        uint            instanceCount,
                                                           [NativeTypeName("uint32_t")]        uint            firstInstance,
                                                           [NativeTypeName("VkBuffer")] ref    VkBuffer        counterBuffer,
                                                           [NativeTypeName("VkDeviceSize")]    ulong           counterBufferOffset,
                                                           [NativeTypeName("uint32_t")]        uint            counterOffset,
                                                           [NativeTypeName("uint32_t")]        uint            vertexStride);
}
