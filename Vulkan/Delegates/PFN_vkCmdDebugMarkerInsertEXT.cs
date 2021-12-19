using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdDebugMarkerInsertEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                              [NativeTypeName("const VkDebugMarkerMarkerInfoEXT *")]
                                                              in VkDebugMarkerMarkerInfoEXT pMarkerInfo);
}
