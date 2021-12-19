using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyPipelineCache([NativeTypeName("VkDevice")]            VkDevice        device,
                                                           [NativeTypeName("VkPipelineCache")] ref VkPipelineCache pipelineCache,
                                                           [NativeTypeName("const VkAllocationCallbacks *")]
                                                           in VkAllocationCallbacks pAllocator);
}
