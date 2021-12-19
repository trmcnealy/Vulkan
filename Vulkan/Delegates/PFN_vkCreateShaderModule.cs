using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateShaderModule([NativeTypeName("VkDevice")] VkDevice device,
                                                             [NativeTypeName("const VkShaderModuleCreateInfo *")]
                                                             in VkShaderModuleCreateInfo pCreateInfo,
                                                             [NativeTypeName("const VkAllocationCallbacks *")]
                                                             in VkAllocationCallbacks pAllocator,
                                                             [NativeTypeName("VkShaderModule *")] out VkShaderModule pShaderModule);
}
