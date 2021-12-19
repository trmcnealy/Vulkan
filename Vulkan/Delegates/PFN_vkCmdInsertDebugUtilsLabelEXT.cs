using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdInsertDebugUtilsLabelEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                  [NativeTypeName("const VkDebugUtilsLabelEXT *")]
                                                                  in VkDebugUtilsLabelEXT pLabelInfo);
}
