using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName(                                           "PFN_vkVoidFunction")]
    public delegate nint PFN_GetPhysicalDeviceProcAddr([NativeTypeName("VkInstance")] VkInstance instance,
                                                       [NativeTypeName("const char *")] 
                                                       utf8string pName);
}
