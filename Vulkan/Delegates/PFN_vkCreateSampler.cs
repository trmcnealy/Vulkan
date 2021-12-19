using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateSampler([NativeTypeName("VkDevice")] VkDevice device,
                                                        [NativeTypeName("const VkSamplerCreateInfo *")]
                                                        in VkSamplerCreateInfo pCreateInfo,
                                                        [NativeTypeName("const VkAllocationCallbacks *")]
                                                        in VkAllocationCallbacks pAllocator,
                                                        [NativeTypeName("VkSampler *")] out VkSampler pSampler);
}
