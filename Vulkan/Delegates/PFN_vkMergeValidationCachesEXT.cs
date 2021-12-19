using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkMergeValidationCachesEXT([NativeTypeName("VkDevice")] VkDevice device,
                                                                   [NativeTypeName("VkValidationCacheEXT")]
                                                                   VkValidationCacheEXT dstCache,
                                                                   [NativeTypeName("uint32_t")] uint srcCacheCount,
                                                                   [NativeTypeName("const VkValidationCacheEXT *")]
                                                                   ref VkValidationCacheEXT[] pSrcCaches);
}
