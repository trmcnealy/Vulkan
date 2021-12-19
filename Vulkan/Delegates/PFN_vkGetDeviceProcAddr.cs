using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName(                                     "PFN_vkVoidFunction")]
    public delegate nint PFN_vkGetDeviceProcAddr([NativeTypeName("VkDevice")] VkDevice device,
                                                 [NativeTypeName("const char *")] 
                                                 utf8string pName);
}
