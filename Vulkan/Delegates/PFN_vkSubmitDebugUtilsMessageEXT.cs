using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkSubmitDebugUtilsMessageEXT([NativeTypeName("VkInstance")] VkInstance instance,
                                                                 VkDebugUtilsMessageSeverityFlagBitsEXT    messageSeverity,
                                                                 [NativeTypeName("VkDebugUtilsMessageTypeFlagsEXT")]
                                                                 uint messageTypes,
                                                                 [NativeTypeName("const VkDebugUtilsMessengerCallbackDataEXT *")]
                                                                 in VkDebugUtilsMessengerCallbackDataEXT pCallbackData);
}
