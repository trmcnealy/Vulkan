using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyPipeline([NativeTypeName("VkDevice")]       VkDevice   device,
                                                      [NativeTypeName("VkPipeline")] ref VkPipeline pipeline,
                                                      [NativeTypeName("const VkAllocationCallbacks *")]
                                                      in VkAllocationCallbacks pAllocator);
}
