using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateDebugUtilsMessengerEXT([NativeTypeName("VkInstance")] VkInstance instance,
                                                                       [NativeTypeName("const VkDebugUtilsMessengerCreateInfoEXT *")]
                                                                       in VkDebugUtilsMessengerCreateInfoEXT pCreateInfo,
                                                                       [NativeTypeName("const VkAllocationCallbacks *")]
                                                                       in VkAllocationCallbacks pAllocator,
                                                                       [NativeTypeName("VkDebugUtilsMessengerEXT *")]
                                                                       ref VkDebugUtilsMessengerEXT[] pMessenger);
}
