using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyPipelineLayout([NativeTypeName("VkDevice")]             VkDevice         device,
                                                            [NativeTypeName("VkPipelineLayout")] ref VkPipelineLayout pipelineLayout,
                                                            [NativeTypeName("const VkAllocationCallbacks *")]
                                                            in VkAllocationCallbacks pAllocator);
}
