using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("VkBool32")]
    public unsafe delegate uint PFN_vkDebugUtilsMessengerCallbackEXT(VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity,
                                                                     [NativeTypeName("VkDebugUtilsMessageTypeFlagsEXT")]
                                                                     uint messageTypes,
                                                                     [NativeTypeName("const VkDebugUtilsMessengerCallbackDataEXT *")]
                                                                     in VkDebugUtilsMessengerCallbackDataEXT pCallbackData,
                                                                     [NativeTypeName("void *")] nint pUserData);
}
