using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdEndDebugUtilsLabelEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer);
}
