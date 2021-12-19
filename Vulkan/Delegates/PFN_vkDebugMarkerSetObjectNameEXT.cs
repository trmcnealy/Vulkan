using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkDebugMarkerSetObjectNameEXT([NativeTypeName("VkDevice")] VkDevice device,
                                                                      [NativeTypeName("const VkDebugMarkerObjectNameInfoEXT *")]
                                                                      in VkDebugMarkerObjectNameInfoEXT pNameInfo);
}
