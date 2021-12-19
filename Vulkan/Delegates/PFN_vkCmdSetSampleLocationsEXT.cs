using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdSetSampleLocationsEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                               [NativeTypeName("const VkSampleLocationsInfoEXT *")]
                                                               VkSampleLocationsInfoEXT[] pSampleLocationsInfo);
}
