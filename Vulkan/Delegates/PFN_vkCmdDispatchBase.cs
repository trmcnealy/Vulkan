using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdDispatchBase([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                               [NativeTypeName("uint32_t")]        uint            baseGroupX,
                                               [NativeTypeName("uint32_t")]        uint            baseGroupY,
                                               [NativeTypeName("uint32_t")]        uint            baseGroupZ,
                                               [NativeTypeName("uint32_t")]        uint            groupCountX,
                                               [NativeTypeName("uint32_t")]        uint            groupCountY,
                                               [NativeTypeName("uint32_t")]        uint            groupCountZ);
}
