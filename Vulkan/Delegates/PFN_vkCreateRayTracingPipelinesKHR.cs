using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateRayTracingPipelinesKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                       [NativeTypeName("VkDeferredOperationKHR")]
                                                                       ref VkDeferredOperationKHR deferredOperation,
                                                                       [NativeTypeName("VkPipelineCache")] ref VkPipelineCache pipelineCache,
                                                                       [NativeTypeName("uint32_t")]            uint            createInfoCount,
                                                                       [NativeTypeName("const VkRayTracingPipelineCreateInfoKHR *")]
                                                                       VkRayTracingPipelineCreateInfoKHR[] pCreateInfos,
                                                                       [NativeTypeName("const VkAllocationCallbacks *")]
                                                                       in VkAllocationCallbacks pAllocator,
                                                                       [NativeTypeName("VkPipeline *")] ref VkPipeline[] pPipelines);
}
