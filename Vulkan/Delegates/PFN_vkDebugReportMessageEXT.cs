using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkDebugReportMessageEXT([NativeTypeName("VkInstance")] VkInstance instance,
                                                     [NativeTypeName("VkDebugReportFlagsEXT")]
                                                     uint flags,
                                                     VkDebugReportObjectTypeEXT         objectType,
                                                     [NativeTypeName("uint64_t")] ulong @object,
                                                     [NativeTypeName("size_t")]   nuint location,
                                                     [NativeTypeName("int32_t")]  int   messageCode,
                                                     [NativeTypeName("const char *")] 
                                                     utf8string pLayerPrefix,
                                                     [NativeTypeName("const char *")] 
                                                     utf8string pMessage);
}
