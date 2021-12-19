using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateRayTracingPipelinesNV([NativeTypeName("VkDevice")]            VkDevice        device,
                                                                      [NativeTypeName("VkPipelineCache")] ref VkPipelineCache pipelineCache,
                                                                      [NativeTypeName("uint32_t")]            uint            createInfoCount,
                                                                      [NativeTypeName("const VkRayTracingPipelineCreateInfoNV *")]
                                                                      VkRayTracingPipelineCreateInfoNV[] pCreateInfos,
                                                                      [NativeTypeName("const VkAllocationCallbacks *")]
                                                                      in VkAllocationCallbacks pAllocator,
                                                                      [NativeTypeName("VkPipeline *")] ref VkPipeline[] pPipelines);
}
