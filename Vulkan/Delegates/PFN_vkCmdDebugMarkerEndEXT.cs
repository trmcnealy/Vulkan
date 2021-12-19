using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdDebugMarkerEndEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer);
}
