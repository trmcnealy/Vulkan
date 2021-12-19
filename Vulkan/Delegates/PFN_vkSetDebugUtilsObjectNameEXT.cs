using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkSetDebugUtilsObjectNameEXT([NativeTypeName("VkDevice")] VkDevice device,
                                                                     [NativeTypeName("const VkDebugUtilsObjectNameInfoEXT *")]
                                                                     in VkDebugUtilsObjectNameInfoEXT pNameInfo);
}
