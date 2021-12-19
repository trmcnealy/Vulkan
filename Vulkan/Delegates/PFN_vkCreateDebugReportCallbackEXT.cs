using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateDebugReportCallbackEXT([NativeTypeName("VkInstance")] VkInstance instance,
                                                                       [NativeTypeName("const VkDebugReportCallbackCreateInfoEXT *")]
                                                                       in VkDebugReportCallbackCreateInfoEXT pCreateInfo,
                                                                       [NativeTypeName("const VkAllocationCallbacks *")]
                                                                       in VkAllocationCallbacks pAllocator,
                                                                       [NativeTypeName("VkDebugReportCallbackEXT *")]
                                                                       out VkDebugReportCallbackEXT pCallback);
}
