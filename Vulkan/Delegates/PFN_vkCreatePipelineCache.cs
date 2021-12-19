using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreatePipelineCache([NativeTypeName("VkDevice")] VkDevice device,
                                                              [NativeTypeName("const VkPipelineCacheCreateInfo *")]
                                                              in VkPipelineCacheCreateInfo pCreateInfo,
                                                              [NativeTypeName("const VkAllocationCallbacks *")]
                                                              in VkAllocationCallbacks pAllocator,
                                                              [NativeTypeName("VkPipelineCache *")] out VkPipelineCache pPipelineCache);
}
