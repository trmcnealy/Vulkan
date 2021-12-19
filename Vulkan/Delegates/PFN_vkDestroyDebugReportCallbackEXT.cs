using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyDebugReportCallbackEXT([NativeTypeName("VkInstance")] VkInstance instance,
                                                                    [NativeTypeName("VkDebugReportCallbackEXT")]
                                                                    ref VkDebugReportCallbackEXT callback,
                                                                    [NativeTypeName("const VkAllocationCallbacks *")]
                                                                    in VkAllocationCallbacks pAllocator);
}
