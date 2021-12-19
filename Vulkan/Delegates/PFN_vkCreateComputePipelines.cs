using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateComputePipelines([NativeTypeName("VkDevice")]        VkDevice        device,
                                                                 [NativeTypeName("VkPipelineCache")] VkPipelineCache pipelineCache,
                                                                 [NativeTypeName("uint32_t")]        uint            createInfoCount,
                                                                 [NativeTypeName("const VkComputePipelineCreateInfo *")]
                                                                 VkComputePipelineCreateInfo[] pCreateInfos,
                                                                 [NativeTypeName("const VkAllocationCallbacks *")]
                                                                 in VkAllocationCallbacks pAllocator,
                                                                 [NativeTypeName("VkPipeline *")] ref VkPipeline pPipelines);
}
