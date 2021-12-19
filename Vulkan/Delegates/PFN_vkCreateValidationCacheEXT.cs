using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateValidationCacheEXT([NativeTypeName("VkDevice")] VkDevice device,
                                                                   [NativeTypeName("const VkValidationCacheCreateInfoEXT *")]
                                                                   in VkValidationCacheCreateInfoEXT pCreateInfo,
                                                                   [NativeTypeName("const VkAllocationCallbacks *")]
                                                                   in VkAllocationCallbacks pAllocator,
                                                                   [NativeTypeName("VkValidationCacheEXT *")]
                                                                   out VkValidationCacheEXT pValidationCache);
}
