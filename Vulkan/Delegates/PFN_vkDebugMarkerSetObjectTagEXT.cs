using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkDebugMarkerSetObjectTagEXT([NativeTypeName("VkDevice")] VkDevice device,
                                                                     [NativeTypeName("const VkDebugMarkerObjectTagInfoEXT *")]
                                                                     in VkDebugMarkerObjectTagInfoEXT pTagInfo);
}
