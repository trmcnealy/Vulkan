using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdDispatch([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                           [NativeTypeName("uint32_t")]        uint            groupCountX,
                                           [NativeTypeName("uint32_t")]        uint            groupCountY,
                                           [NativeTypeName("uint32_t")]        uint            groupCountZ);
}
