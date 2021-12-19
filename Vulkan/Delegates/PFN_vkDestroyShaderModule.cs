using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyShaderModule([NativeTypeName("VkDevice")]           VkDevice       device,
                                                          [NativeTypeName("VkShaderModule")] ref VkShaderModule shaderModule,
                                                          [NativeTypeName("const VkAllocationCallbacks *")]
                                                          in VkAllocationCallbacks pAllocator);
}
