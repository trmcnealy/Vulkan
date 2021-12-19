using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName(                                          "VkBool32")]
    public delegate uint PFN_vkDebugReportCallbackEXT([NativeTypeName("VkDebugReportFlagsEXT")] uint flags,
                                                      VkDebugReportObjectTypeEXT                     objectType,
                                                      [NativeTypeName("uint64_t")] ulong             @object,
                                                      [NativeTypeName("size_t")]   nuint             location,
                                                      [NativeTypeName("int32_t")]  int               messageCode,
                                                      [NativeTypeName("const char *")] 
                                                      utf8string pLayerPrefix,
                                                      [NativeTypeName("const char *")] 
                                                      utf8string pMessage,
                                                      [NativeTypeName("void *")] nint pUserData);
}
