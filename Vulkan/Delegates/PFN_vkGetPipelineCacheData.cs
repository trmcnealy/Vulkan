using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPipelineCacheData([NativeTypeName("VkDevice")]            VkDevice        device,
                                                               [NativeTypeName("VkPipelineCache")] ref VkPipelineCache pipelineCache,
                                                               [NativeTypeName("size_t *")]            UIntPtr*        pDataSize,
                                                               [NativeTypeName("void *")]              nint            pData);
}
