using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyInstance([NativeTypeName("VkInstance")] VkInstance instance,
                                                      [NativeTypeName("const VkAllocationCallbacks *")]
                                                      in VkAllocationCallbacks pAllocator);
}
