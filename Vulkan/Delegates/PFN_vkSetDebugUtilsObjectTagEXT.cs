using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkSetDebugUtilsObjectTagEXT([NativeTypeName("VkDevice")] VkDevice device,
                                                                    [NativeTypeName("const VkDebugUtilsObjectTagInfoEXT *")]
                                                                    in VkDebugUtilsObjectTagInfoEXT pTagInfo);
}
