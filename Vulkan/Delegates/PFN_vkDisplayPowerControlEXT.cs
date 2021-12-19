using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkDisplayPowerControlEXT([NativeTypeName("VkDevice")]         VkDevice     device,
                                                                 [NativeTypeName("VkDisplayKHR")] ref VkDisplayKHR display,
                                                                 [NativeTypeName("const VkDisplayPowerInfoEXT *")]
                                                                 VkDisplayPowerInfoEXT[] pDisplayPowerInfo);
}
