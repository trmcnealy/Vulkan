using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyDebugUtilsMessengerEXT([NativeTypeName("VkInstance")] VkInstance instance,
                                                                    [NativeTypeName("VkDebugUtilsMessengerEXT")]
                                                                    ref VkDebugUtilsMessengerEXT messenger,
                                                                    [NativeTypeName("const VkAllocationCallbacks *")]
                                                                    in VkAllocationCallbacks pAllocator);
}
