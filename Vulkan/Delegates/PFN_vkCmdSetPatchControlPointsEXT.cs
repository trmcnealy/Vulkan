using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetPatchControlPointsEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                           [NativeTypeName("uint32_t")]        uint            patchControlPoints);
}
