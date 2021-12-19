using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI([NativeTypeName("VkDevice")]         VkDevice     device,
                                                                                        [NativeTypeName("VkRenderPass")] ref VkRenderPass renderpass,
                                                                                        VkExtent2D*                                       pMaxWorkgroupSize);
}
