using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkEndCommandBuffer([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer);
}
