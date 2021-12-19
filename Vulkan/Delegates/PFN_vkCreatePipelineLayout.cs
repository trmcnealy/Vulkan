using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreatePipelineLayout([NativeTypeName("VkDevice")] VkDevice device,
                                                               [NativeTypeName("const VkPipelineLayoutCreateInfo *")]
                                                               in VkPipelineLayoutCreateInfo pCreateInfo,
                                                               [NativeTypeName("const VkAllocationCallbacks *")]
                                                               in VkAllocationCallbacks pAllocator,
                                                               [NativeTypeName("VkPipelineLayout *")] out VkPipelineLayout pPipelineLayout);
}
