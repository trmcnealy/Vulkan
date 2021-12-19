using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyValidationCacheEXT([NativeTypeName("VkDevice")] VkDevice device,
                                                                [NativeTypeName("VkValidationCacheEXT")]
                                                                ref VkValidationCacheEXT validationCache,
                                                                [NativeTypeName("const VkAllocationCallbacks *")]
                                                                in VkAllocationCallbacks pAllocator);
}
