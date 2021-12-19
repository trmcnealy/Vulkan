using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetValidationCacheDataEXT([NativeTypeName("VkDevice")] VkDevice device,
                                                                    [NativeTypeName("VkValidationCacheEXT")]
                                                                    ref VkValidationCacheEXT validationCache,
                                                                    [NativeTypeName("size_t *")] in UIntPtr pDataSize,
                                                                    [NativeTypeName("void *")]   nint     pData);
}
