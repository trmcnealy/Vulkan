using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetRenderAreaGranularity([NativeTypeName("VkDevice")]         VkDevice     device,
                                                               [NativeTypeName("VkRenderPass")] ref VkRenderPass renderPass,
                                                               VkExtent2D*                                       pGranularity);
}
