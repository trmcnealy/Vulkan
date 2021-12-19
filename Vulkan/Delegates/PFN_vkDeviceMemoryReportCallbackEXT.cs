using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDeviceMemoryReportCallbackEXT([NativeTypeName("const VkDeviceMemoryReportCallbackDataEXT *")] in VkDeviceMemoryReportCallbackDataEXT pCallbackData,
                                                                    [NativeTypeName("void *")]                                      nint                                 pUserData);
}
