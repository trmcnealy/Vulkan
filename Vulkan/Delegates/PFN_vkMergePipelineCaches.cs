using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkMergePipelineCaches([NativeTypeName("VkDevice")]            VkDevice        device,
                                                              [NativeTypeName("VkPipelineCache")] ref VkPipelineCache dstCache,
                                                              [NativeTypeName("uint32_t")]            uint            srcCacheCount,
                                                              [NativeTypeName("const VkPipelineCache *")]
                                                              ref VkPipelineCache[] pSrcCaches);
}
